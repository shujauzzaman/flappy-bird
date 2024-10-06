using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private Button startButton;
    [SerializeField] private Button endButton;
    [SerializeField] TextMeshProUGUI scoreText;

    int score = 0;

    void Start()
    {
        Time.timeScale = 0; // Pause the game initially
        startButton.gameObject.SetActive(true);
        endButton.gameObject.SetActive(false);
    }

    public void StartGame()
    {
        Time.timeScale = 1; // Resume the game
        startButton.gameObject.SetActive(false);
    }

    public void ShowEndGameUI()
    {
        Time.timeScale = 0; // Pause the game
        endButton.gameObject.SetActive(true);
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void UpdateScore(){
        score++;
        scoreText.text = "Score: " + score.ToString();
    }
}
