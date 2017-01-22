using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class GameManager : MonoBehaviour
{
    [SerializeField] private int points;
    [SerializeField] private Text pointsText;
    [SerializeField] private Text highScoreText;
    [SerializeField] private GameObject deadPanel;
    [SerializeField] private AudioSource deadSound;

    private int highScore;
    private string highScoreKey = "HighScore";
    private string gameName = "FaceTheWaves_";

    private void Start()
    {
        highScore = PlayerPrefs.GetInt(gameName + highScoreKey, 0);
        highScoreText.text = "HI-Score: " + highScore;
    }

    public void AddPoints(int pointsToAdd)
    {
        points += pointsToAdd;
        pointsText.text = "Points: " + points;
    }

    public void Dead()
    {
        deadPanel.SetActive(true);
        deadSound.Play();
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }

    private void OnDisable()
    {

        if (points > highScore)
        {
            PlayerPrefs.SetInt(gameName + highScoreKey, points);
            PlayerPrefs.Save();
        }

    }

}
