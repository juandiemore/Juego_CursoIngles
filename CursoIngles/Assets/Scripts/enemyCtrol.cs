﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyCtrol : MonoBehaviour
{

    private Animator anim;
    
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void golpear()
    {
        anim.SetTrigger("punchi");
    }

      public void morir()
    {
        
        anim.SetTrigger("die");
    }
}
