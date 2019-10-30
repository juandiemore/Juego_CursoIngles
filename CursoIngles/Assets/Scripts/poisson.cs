using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class poisson : MonoBehaviour
{
    public float up;
    public float side;
    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider other) {
        if(other.tag == "Player"){
     //       other.GetComponent<vida_aj>().TakeDamage(pois);
         //   other.GetComponent<ControlPlayer1>().dolor();
            Rigidbody rb = other.GetComponent<Rigidbody>();
            rb.AddForce(transform.up*up);
            rb.AddForce(transform.forward*-side);
        }
        
    }
}
