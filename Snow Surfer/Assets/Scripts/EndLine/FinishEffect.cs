using UnityEngine;

public class FinishEffect : MonoBehaviour
{
    [SerializeField] private ParticleSystem finishEffect;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            finishEffect.Play();
            Debug.Log("Load the Next Scene");
        }
    }
}