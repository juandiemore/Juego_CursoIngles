using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    // Start is called before the first frame update
   
    public bool hasKey;
    void Start()
    {
    
        hasKey = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other) {
        if(other.tag == "key")
        {
            other.transform.gameObject.SetActive(false);
      
            hasKey = true;

        }

    }
    public bool GetKey(){
        return hasKey;
    }
}
