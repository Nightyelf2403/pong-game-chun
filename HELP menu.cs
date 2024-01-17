using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelpMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;

    public GameObject HelpmenuUi;

     void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {

                Resume();

            }else
            {
                Pause();
            }

        }

        
    }

    void Resume()
    {
        HelpmenuUi.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    void Pause()
    {
        HelpmenuUi.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }
}

  
