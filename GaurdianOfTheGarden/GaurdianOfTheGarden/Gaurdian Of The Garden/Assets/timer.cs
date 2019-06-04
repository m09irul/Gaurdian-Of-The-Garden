using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timer : MonoBehaviour
{
    [SerializeField] float time = 10;
    bool finishedTimerTrigger = false;

    // Update is called once per frame
    void Update()
    {
        if (finishedTimerTrigger) { return; }
        GetComponent<Slider>().value = Time.timeSinceLevelLoad / time;
        bool timehasfinished = (Time.timeSinceLevelLoad >= time);
        if(timehasfinished)
        {
            FindObjectOfType<lvlController>().lvlTimer();
            finishedTimerTrigger = true;
        }
    }
}
