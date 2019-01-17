using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI : MonoBehaviour {

    private GameObject StartMenu;
    private GameObject GUI;

    public static bool GameIsPaused = false;

    void Start()
    {
        StartMenu = GameObject.FindGameObjectWithTag("StartMenu");
        GUI = GameObject.FindGameObjectWithTag("GUI");
        //GUI.SetActive(false);
        Time.timeScale = 0.0f;
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            if(GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    void Resume()
    {
        StartMenu.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    void Pause()
    {
        StartMenu.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    public void ClickPlay()
    {
        Time.timeScale = 1.0f;
        StartMenu.SetActive(false);
        GUI.SetActive(true);
    }
}
