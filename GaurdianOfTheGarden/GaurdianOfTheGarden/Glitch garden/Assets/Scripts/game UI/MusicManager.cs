using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MusicManager : MonoBehaviour
{
    public AudioClip[] levelMusicChangeArray;
    private AudioSource audioSource;
    bool trig = false;
    
 
    // Start is called before the first frame update
    private void Awake()
    {
 
        DontDestroyOnLoad(gameObject);
        //Debug.Log("Dont Destroy on load: " + name);
    }

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();

    }

   
    public void ChangeVolume(float volume)
    {
        audioSource.volume = volume;
    }

    private void OnLevelWasLoaded(int level)
    {

        if (level == 2)
        {

            //Debug.Log("Hello");
            DontDestroyOnLoad(audioSource);
            trig = true;
        }
        else if(level == 3)
        {
            DontDestroyOnLoad(audioSource);
            trig = true;
        }
        else if (level == 1 && trig == true)
        {
           // Debug.Log("Hi");
            DontDestroyOnLoad(audioSource);

        }


        //Debug.Log("Playing : " + thisLevelMuisc);

        else
        {
            AudioClip thisLevelMuisc = levelMusicChangeArray[level];
            audioSource.clip = thisLevelMuisc;
            audioSource.loop = true;
            audioSource.Play();
            trig = false;
        }
        
 
    }

    public void SetVolume(float volume)
    {
        audioSource.volume = volume;
    }

}
