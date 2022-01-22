using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jabba : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject otherobject = collision.gameObject;
        if (collision.GetComponent<Defender>().tag== "Gravestone")
        {
            GetComponent<lizard_move>().Attack(otherobject);
        }   
    }
    private void Start()
    {
        var hlth = PlayerPrefsManager.GetDifficulty();
        FindObjectOfType<health>().Health = 300f * hlth;
    }
}
