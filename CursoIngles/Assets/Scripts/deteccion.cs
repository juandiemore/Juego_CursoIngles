﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class deteccion : MonoBehaviour
{
  [SerializeField] public GameObject msgPanel;

        // Start is called before the first frame update
    void Awake()
    {
        GetComponent<Collider>();
    }
    void Start(){
        msgPanel.SetActive(false);
    }
    // Update is called once per frame
    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "enemy"){
         msgPanel.SetActive(true);
        }
    }

        void OnTriggerExit(Collider other)
    {
        if(other.tag == "enemy"){
         msgPanel.SetActive(false);
        }
    }
}