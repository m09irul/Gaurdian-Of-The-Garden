using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetStartVolume : MonoBehaviour
{
    private MusicManager musicManger;
    float volume;
 
    void Start()
    { 

        musicManger = GameObject.FindObjectOfType<MusicManager>();

        if(musicManger)
        {
            PlayerPrefsManager.SetMasterVolume(0.5f);
            volume = PlayerPrefsManager. GetMasterVolume();
            musicManger.SetVolume(volume);
            
        }
        

    }

}
