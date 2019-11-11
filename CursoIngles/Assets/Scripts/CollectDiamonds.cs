using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectDiamonds : MonoBehaviour
{
    // Start is called before the first frame update
    public Text contador;
    private int Colector;

    void Start()
    {
        SetCount();
    }
    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "diamond"){
        Colector+=1;
        other.transform.gameObject.SetActive(false);
        SetCount();
      }
    }

    void SetCount()
    {
        if(Colector <= 9){
        contador.text = "0"+Colector.ToString ();
        }else{
             contador.text = ""+Colector.ToString ();
        }
    }
}
