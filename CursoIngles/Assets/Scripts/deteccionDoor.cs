using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class deteccionDoor : MonoBehaviour
{
  [SerializeField] public GameObject msgPanel;
  public GameObject my;
  private OpenDoor open;
  static Animator anim;
        // Start is called before the first frame update
    void Awake()
    {
        GetComponent<Collider>();
        open = my.GetComponent<OpenDoor>();
    }
    void Start(){
        msgPanel.SetActive(false);
        anim = GetComponent<Animator>();
    }
    // Update is called once per frame
    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player"){
         msgPanel.SetActive(true);

         if(this.tag == "door"){
             if(open.hasKey){
                 anim.SetTrigger("OwnKey");
             }
         }
        }
    }

        void OnTriggerExit(Collider other)
    {
        if(other.tag == "Player"){
         msgPanel.SetActive(false);
        }
    }
}