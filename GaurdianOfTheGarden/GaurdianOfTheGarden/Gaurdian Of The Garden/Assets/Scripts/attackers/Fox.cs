using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fox : MonoBehaviour
{
    int count = 0;
    private void Start()
    {
        var hlth = PlayerPrefsManager.GetDifficulty();
        FindObjectOfType<health>().Health = 200f * hlth;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject otherobject = collision.gameObject;
        if ( collision.GetComponent<Defender>())
        {
            if(count==1)
                GetComponent<lizard_move>().Attack(otherobject);
            else if (count == 0)
            {
                GetComponent<lizard_move>().Jump(otherobject);
                count = 1;
            }
        }
    }
}
