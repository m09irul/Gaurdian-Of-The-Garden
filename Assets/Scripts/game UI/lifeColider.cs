using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lifeColider : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        FindObjectOfType<Life_display>().remove_life();
        Destroy(collision.gameObject);
        
        
        
    }
   
}
