using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] private Button playAgainButton;

    private void Awake()
    {
        playAgainButton.onClick.AddListener(PlayAgain);
    }

    void PlayAgain()
    {
        SceneManager.LoadScene("SampleScene");
    }

    void ExitGame()
    {
        Application.Quit();
    }

    void PauseGame()
    {
        //bat panel
        Time.timeScale = 0;
    }

    void ContinueGame()
    {
        //tat panel
        Time.timeScale = 1f;
    }
}
