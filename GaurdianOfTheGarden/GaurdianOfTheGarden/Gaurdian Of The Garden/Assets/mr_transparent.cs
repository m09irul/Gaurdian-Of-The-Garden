using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mr_transparent : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject otherobject = collision.gameObject;
        if (collision.GetComponent<Defender>())
        {
            GetComponent<lizard_move>().Attack(otherobject);
        }
    }
    private void Start()
    {
        var hlth = PlayerPrefsManager.GetDifficulty();
        FindObjectOfType<health>().Health = 150f * hlth;
    }
}
