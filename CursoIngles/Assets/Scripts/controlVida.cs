using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controlVida : MonoBehaviour
{   
    private Animator anim;
    private int vida = 3;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        anim.SetInteger("vida",vida);
    }

        
    public int GetVida(){
        return vida;
    }

    public void SetVida(int _vida){
        this.vida = _vida;
    }
        

}
