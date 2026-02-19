using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashEffect : MonoBehaviour
{
    [Header("Particle System")]
    [SerializeField] private ParticleSystem crashParticleSystem;
    [SerializeField] bool hasCrashed = false;

    [Header("Reference")]
    [SerializeField] private Player player;
    [SerializeField] private AudioClip crashSFX;

    [Header("Delay Settings")]
    [SerializeField] private float delayBeforeRestart = 0.5f;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Ground" && !hasCrashed)
        {
            hasCrashed = true;
            crashParticleSystem.Play();
            player.DisableControls();
            GetComponent<AudioSource>().PlayOneShot(crashSFX);
            Invoke("RestartLevel", delayBeforeRestart);
            Debug.Log("Player has crashed!");
        }
    }

    void RestartLevel()
    {
        SceneManager.LoadScene(0);
    }
}