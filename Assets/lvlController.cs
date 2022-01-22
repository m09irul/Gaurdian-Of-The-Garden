using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class lvlController : MonoBehaviour
{
    [SerializeField] GameObject winload,lostload,camera;
    [SerializeField] float waitToLoad = 4f;
    int numOfAttackers = 0;
    bool shouldweproceed = true;
    bool done = true;
    bool timerFinished = false;
    private void Start()
    {
        winload.SetActive(false);
        //loadedwin.SetActive(false);
        lostload.SetActive(false);
        //loadedlost.SetActive(false);
       

        
    }
    public void spawnedAttackers()
    {
        numOfAttackers++;
        //Debug.Log(numOfAttackers);
    }
    public void distroyedAttackers()
    {
        numOfAttackers--;
        if (timerFinished && numOfAttackers <= 0)
        {
            StartCoroutine(Handlewin());
        }
    }
    IEnumerator Handlewin()
    {
        if (shouldweproceed)
        {
            done = false;

            FindObjectOfType<WinnerScene>().getIndex(SceneManager.GetActiveScene().buildIndex);
            if (SceneManager.GetActiveScene().buildIndex == 4)
            {
                PlayerPrefsManager.UnlockLevel(2);
            }
            else if (SceneManager.GetActiveScene().buildIndex == 5)
            {
                PlayerPrefsManager.UnlockLevel(3);
            }
            else if (SceneManager.GetActiveScene().buildIndex == 6)
            {
                PlayerPrefsManager.UnlockLevel(4);
            }
            else if (SceneManager.GetActiveScene().buildIndex == 7)
            {
                PlayerPrefsManager.UnlockLevel(5);
            }

            winload.SetActive(true);
            
            

            
            yield return new WaitForSeconds(3f);
            camera.GetComponent<AudioSource>().Stop();

            SceneManager.LoadScene(9);

            
        }
        

    }
     IEnumerator Handlelost()
    {
        if (done)
        {
            shouldweproceed = false;

            FindObjectOfType<WinnerScene>().getIndex(SceneManager.GetActiveScene().buildIndex);

            lostload.SetActive(true);

            yield return new WaitForSeconds(waitToLoad);
            camera.GetComponent<AudioSource>().Stop();

            
            SceneManager.LoadScene(10);

        }
    }
    public void startHandlelost()
    {
        StartCoroutine(Handlelost());
    }


    public void lvlTimer()
    {
        timerFinished = true;
        stopspwaners();
    }
    void stopspwaners()
    {
        lizard_Spawn[] spwanerarray = FindObjectsOfType<lizard_Spawn>();
        foreach(lizard_Spawn spwaner in spwanerarray)
        {
            spwaner.stopSpwaning();
        }
    }
}
