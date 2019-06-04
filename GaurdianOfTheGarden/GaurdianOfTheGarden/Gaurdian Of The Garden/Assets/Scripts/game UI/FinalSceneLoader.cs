using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinalSceneLoader : MonoBehaviour
{
    
    public void Winner()
    {
        SceneManager.LoadScene(6);
    }

    public void Losser()
    {
        SceneManager.LoadScene(7);
    }
}
