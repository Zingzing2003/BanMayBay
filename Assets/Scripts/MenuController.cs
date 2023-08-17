using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public Button ExitButton;

    public Button PlayButton;

    public Button GuideButton;

    public Button closeButton;


    public GameObject GuidePanel;

    public GameObject SystemPanel;
    // Start is called before the first frame update
    void Awake()
    {
        PlayButton.onClick.AddListener(OnPlay);
        ExitButton.onClick.AddListener(OnExit);
        GuideButton.onClick.AddListener(OnGuide);
        closeButton.onClick.AddListener(OnClose);
    }

    private void OnPlay()
    {
        SceneManager.LoadScene("Gameplay");
        
    }
    private void OnExit()
    {
        Application.Quit();
    }

    private void OnGuide()
    {
        SystemPanel.SetActive(false);
        GuidePanel.SetActive(true);
        Debug.Log("huong dan");
    }

    private void OnClose()
    {
        SystemPanel.SetActive(true);
        GuidePanel.SetActive(false);
    }
    
}
