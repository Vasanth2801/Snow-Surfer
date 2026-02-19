using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishEffect : MonoBehaviour
{
    [SerializeField] private ParticleSystem finishEffect;
    [SerializeField] private float loadDelay = 0.5f;
     
    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            finishEffect.Play();
            GetComponent<AudioSource>().Play();
            Debug.Log("Load the Next Scene");
            Invoke("LoadNextScene",loadDelay);
        }
    }

    void LoadNextScene()
    {
        SceneManager.LoadScene(1);
    }
}