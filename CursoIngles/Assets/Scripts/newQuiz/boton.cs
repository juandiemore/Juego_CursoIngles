using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boton : MonoBehaviour
{
    [SerializeField] public GameObject enemy;

    [SerializeField] public GameObject my;
    private controlPlayer1 ctrl;

    private move move;
    private enemyCtrol eCtrl;
   // private Animator anim;
    void Start()
    {
        //anim = GetComponent<Animator>();
    eCtrl = enemy.GetComponent<enemyCtrol>();
    move = my.GetComponent<move>();
     ctrl = my.GetComponent<controlPlayer1>(); 

    }

    // Update is called once per frame
    public void Update()
    {
        
    }

    public void correcto(){
        ctrl.golpear();
        eCtrl.morir();
       
        move.setSpeed(2f);
  
    }

    public void incorrecto(){
       eCtrl.golpear();
    }
}
