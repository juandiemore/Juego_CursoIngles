using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] public GameObject imagen;
    public bool hasKey;
    void Start()
    {
        imagen = GetComponent<GameObject>();
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
            imagen.SetActive(true);
            hasKey = true;

        }
    }
}
