using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exit : MonoBehaviour
{
    bool isQuit;
    [SerializeField] GameObject popuppanel;

    private void Start()
    {
        popuppanel.SetActive(false);
    }

    void Update()
    {
        if(isQuit)
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                Application.Quit();
            }
        }
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            popuppanel.SetActive(true);
            isQuit = true;
            StartCoroutine(quitTimer());
        }
    }

   IEnumerator quitTimer()
    {
        yield return new WaitForSeconds(0.6f);
        isQuit = false;
        popuppanel.SetActive(false);
    }
}
