﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sideController : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log(collision.gameObject.name);
        Destroy(collision.gameObject);
    }
}
