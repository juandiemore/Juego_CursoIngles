﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controlPlayer1 : MonoBehaviour
{
    static Animator anim;
    private move movi;

    // Start is called before the first frame update
    void Start()
    {
    anim = GetComponent<Animator>();
    movi = GetComponent<move>();


    }

    // Update is called once per frame
    void Update()
    {
        if(movi.movimiento != 0){
            anim.SetBool("IsWalking",true);
        }else{
            anim.SetBool("IsWalking",false);
        }

        
    }

    public void golpear(){
        anim.SetTrigger("punch");
    }
}
