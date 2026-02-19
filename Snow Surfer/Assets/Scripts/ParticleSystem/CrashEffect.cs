using UnityEngine;

public class CrashEffect : MonoBehaviour
{
    [Header("Particle System")]
    [SerializeField] private ParticleSystem crashParticleSystem;
    [SerializeField] bool hasCrashed = false;

    [Header("Reference")]
    [SerializeField] private Player player;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Ground" && !hasCrashed)
        {
            hasCrashed = true;
            crashParticleSystem.Play();
            player.DisableControls();
            Debug.Log("Player has crashed!");
        }
    }
}