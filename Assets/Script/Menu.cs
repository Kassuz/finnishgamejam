﻿using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class Menu : MonoBehaviour
{

    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }

    public void ExitGame()
    {
        Application.Quit();
    }
	
    public void ResetScore()
    {
        PlayerPrefs.DeleteKey("FaceTheWaves_HighScore");
    }
}
