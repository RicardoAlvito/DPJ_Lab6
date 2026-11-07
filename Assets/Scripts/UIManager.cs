using System;
using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public static UIManager Instance { get; private set; }
    [SerializeField]private TMP_Text scoreText;
    [SerializeField]private TMP_Text livesText;
    private int startLives = 3;
    public int score = 0;
    private int lives = 0;

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
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

    public void SetLives(int newLives)
    {
        lives = newLives;
        UpdateLivesUI();
    }
    public void AddScore(int amount)
    {
        score += amount;
        UpdateScoreUI();
    }
    public void AddLives(int amount)
    {
        lives += amount;
        UpdateLivesUI();
    }
    public void munusLives(int amount)
    {
        lives -= amount;
        UpdateLivesUI();
    }

}
