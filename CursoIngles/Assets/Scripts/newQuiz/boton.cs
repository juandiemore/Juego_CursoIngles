using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boton : MonoBehaviour
{
    [SerializeField] public GameObject enemy;

    [SerializeField] public GameObject my;
    private controlPlayer1 ctrl;
    private enemyCtrol eCtrl;
   // private Animator anim;
    void Start()
    {
        //anim = GetComponent<Animator>();
    eCtrl = enemy.GetComponent<enemyCtrol>();
    
     ctrl = my.GetComponent<controlPlayer1>(); 
    
    }

    // Update is called once per frame
    public void Update()
    {
        
    }

    public void correcto(){
        ctrl.golpear();
    }

    public void incorrecto(){
       eCtrl.golpear();
    }
}
