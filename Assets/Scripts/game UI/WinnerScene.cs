using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinnerScene : MonoBehaviour
{
    public static int finalsceneIndex;
    public void getIndex(int scene)
    {
        finalsceneIndex = scene;
       // Debug.Log("get= " + finalsceneIndex);

    }

    public void Playagainbutton()
    {
        SceneManager.LoadScene(1);
    }
    public void tryagain()
    {
        //Debug.Log(finalsceneIndex);
        SceneManager.LoadScene(finalsceneIndex);
    }

    public void nextbutton()
    {
        if (finalsceneIndex == 4)
        {
            PlayerPrefsManager.UnlockLevel(2);
            SceneManager.LoadScene(5);
        }
        else if (finalsceneIndex == 5)
        {
            PlayerPrefsManager.UnlockLevel(3);
            SceneManager.LoadScene(6);
        }
        else if (finalsceneIndex == 6)
        {
            PlayerPrefsManager.UnlockLevel(4);
            SceneManager.LoadScene(7);
        }
        else if (finalsceneIndex == 7)
        {
            PlayerPrefsManager.UnlockLevel(5);
            SceneManager.LoadScene(8);
        }
        else if (finalsceneIndex == 8)
        {
            SceneManager.LoadScene(1);
        }

    }
}
