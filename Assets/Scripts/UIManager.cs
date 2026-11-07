using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public static UIManager Instance { get; private set; }
    [SerializeField]private TMP_Text scoreText;
    [SerializeField]private TMP_Text livesText;
    private int startLives = 3;
    private int score = 0;
    private int lives = 0;

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        lives = startLives;
        score = 0;
        UpdateScoreUI();
        UpdateLivesUI();
    }

    void UpdateScoreUI()
    {
        scoreText.text = "Pontos: " + score;
    }

    void UpdateLivesUI() 
    {
        livesText.text = "Vida: " + lives;
    }

    void SetLives(int newLives)
    {
        lives = newLives;
        UpdateLivesUI();
    }
    void AddScore(int amount)
    {
        score += amount;
        UpdateScoreUI();
    }


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
