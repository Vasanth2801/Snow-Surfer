using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;

    [SerializeField] private int score = 0;
    [SerializeField] private TextMeshProUGUI scoreText;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void Start()
    {
        scoreText.text = "Score: " + score.ToString();
    }

    void Update()
    {
        scoreText.text = "Score: " + score.ToString();
    }

    public void AddScore(int amount)
    {
        score += amount;
        Debug.Log("Score: " + score);
    }
}