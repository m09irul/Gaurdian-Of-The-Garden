using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Life_display : MonoBehaviour
{
    [SerializeField] int Life = 999;
    [SerializeField] int damage = 1;
    [SerializeField]Text Lifetxt;
    private void Start()
    {
        update_display();
    }
    void update_display()
    {
        Lifetxt.text = Life.ToString();
    }
   

    public void remove_life ()
    {
        if (Life <= 1)
        {
            Lifetxt.text = "0";

            FindObjectOfType<lvlController>().startHandlelost();
        }
        else
        {
            Life -= damage;
            update_display();
        }
        
    }
}
