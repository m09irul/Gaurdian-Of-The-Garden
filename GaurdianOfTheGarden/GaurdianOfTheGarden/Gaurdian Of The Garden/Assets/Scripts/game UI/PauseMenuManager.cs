using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenuManager : MonoBehaviour
{
    public GameObject pauseMenuPanel;
    public static bool gameIsPaused = false;
    

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            pauseMenuPanel.SetActive(true);
            gameIsPaused = true;
            Pause();
        }
    }

    public void PauseButtonPressed()
    {
        pauseMenuPanel.SetActive(true);
        gameIsPaused = true;
        Pause();
    }

    public void Resume()
    {
        gameIsPaused = false;
        pauseMenuPanel.SetActive(false);
        Time.timeScale = 1f;
    }

    void Pause()
    {
        Time.timeScale = 0f;
    }

    public void Restart()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void HomeButton()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(1);
        
    }


}
