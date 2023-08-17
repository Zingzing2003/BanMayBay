using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.UIElements;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public static int score;
    public static int hp;
    public GameObject WindowPanel;

    public GameObject EnemyManager;

    public GameObject PlayerShip;
    //public Button PlayButton;
    public Text text;
    public Text textScore;
    public Button ReplayButton;
    
    public Button ExitButton;
    
    // Start is called before the first frame update
    void Awake()
    {
        GameController.hp = 25;
        ReplayButton.onClick.AddListener(OnReplay );
        ExitButton.onClick.AddListener(OnExit);
    }

    private void Update()
    {
        textScore.text = "Score : " + GameController.score;
    }

    private void OnReplay()
    {
        GameController.score = 0;
        GameController.hp = 25;
        EnemyManager.SetActive(true);
        PlayerShip.SetActive(true);
        SceneManager.LoadScene("Gameplay");
        Debug.Log("replay");
    }

    private void OnExit()
    {
        Application.Quit();
        Debug.Log("exit ");
    }
    
    public void win()
    {
        if (WindowPanel.activeSelf == false)
        {
            WindowPanel.SetActive(true);
            EnemyManager.SetActive(false);
            PlayerShip.SetActive(false);
           // GameController.score = 0;
            Debug.Log( "thang !");
        }
        
        
    }

    public void lose()
    {
        if (WindowPanel.activeSelf == false)
        {
            text.text = "YOU LOSE !";
            WindowPanel.SetActive(true);
            PlayerShip.SetActive(false);
            EnemyManager.SetActive(false);
            Debug.Log("thua !");
        }
        
    }
}
