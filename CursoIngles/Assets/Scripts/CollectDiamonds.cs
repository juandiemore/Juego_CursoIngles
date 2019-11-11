using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectDiamonds : MonoBehaviour
{
    // Start is called before the first frame update
    public int Colector = 0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void onTriggerEnter(Collider other){
        if(other.tag == "Player"){
           // this.transform.position ;
            
        }
    }
}
