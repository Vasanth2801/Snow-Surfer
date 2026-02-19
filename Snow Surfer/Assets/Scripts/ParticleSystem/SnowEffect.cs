using UnityEngine;

public class SnowEffect : MonoBehaviour
{
    [SerializeField] private ParticleSystem snowParticleSystem;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Ground")
        {
            snowParticleSystem.Play();
        }
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Ground")
        {
            snowParticleSystem.Stop();
        }
    }
}