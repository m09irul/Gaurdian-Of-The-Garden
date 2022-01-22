using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lizard_move : MonoBehaviour
{
     [SerializeField]float speed =1f;
    GameObject currentTarget;

   

    void Update()
    {
        transform.Translate(Vector2.left*Time.deltaTime*speed);
        animUpdate();
    }
    private void Awake()
    {
        FindObjectOfType<lvlController>().spawnedAttackers();

    }
    private void OnDestroy()
    {
        lvlController lc = FindObjectOfType<lvlController>();
        if(lc!=null)
         lc.distroyedAttackers();
    }
    private void animUpdate()
    {
        if(!currentTarget)
            GetComponent<Animator>().SetBool("isAttacking", false);
    }

    void movespeed(float new_speed)
    {
        speed = new_speed;
    }
    public void Attack(GameObject target)
    {
        GetComponent<Animator>().SetBool("isAttacking", true);
        currentTarget = target;
    }
    public void Jump(GameObject target)
    {
        GetComponent<Animator>().SetTrigger("jumpButton");
    }
    void strikeTarget(float damage)
    {
        if (!currentTarget)
            return;
        health hlth = currentTarget.GetComponent<health>();
        if(hlth)
        {
            hlth.Shoot(damage);
        }
    }
    
}
