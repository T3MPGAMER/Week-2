﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Enemy")
        {
            Destroy(col.gameObject);
            //add an explosion or something
            //destroy the projectile that just caused the trigger collision
            Destroy(gameObject);
        }
    }
   }
