using UnityEngine;

public class Coin : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            ScoreManager.instance.AddScore(1);
            Debug.Log("Coin Collected");
            Destroy(gameObject,0.1f);
        }
    }
}