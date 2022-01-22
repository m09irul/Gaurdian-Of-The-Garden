using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    [SerializeField] float timeToWait = 2.5f;
    [SerializeField] GameObject panel,INS_button,howToPlayPanel;
    public int currentSceneIndex;
    // Start is called before the first frame update
    void Start()
    {
        panel.SetActive(false);
        howToPlayPanel.SetActive(false);
        INS_button.SetActive(true);
        currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        if(currentSceneIndex == 0)
        {
            StartCoroutine(WaitForTime());
        }
    }

    IEnumerator WaitForTime()
    {
        yield return new WaitForSeconds(timeToWait);
        LoadNextScene();
    }

    public void LoadNextScene()
    {
        SceneManager.LoadScene(currentSceneIndex + 1);
    }

   

   public  void Startbutton()
    {
        SceneManager.LoadScene(3);
    }
    public  void HTP_Button()
    {
        howToPlayPanel.SetActive(true);

    }
    public  void HTP_Button_BAck()
    {
        howToPlayPanel.SetActive(false);

    }
    public  void instructionbutton()
    {
        INS_button.SetActive(false);
        panel.SetActive(true);
    }
    public  void backinstructionbutton()
    {
        
        panel.SetActive(false);
        INS_button.SetActive(true);
    }

    public void QuitButton()
    {
        Application.Quit();
    }

    public void OptionButton()
    {
        SceneManager.LoadScene(2);
    }

}
