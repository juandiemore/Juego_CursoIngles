using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class deteccionEnemy : MonoBehaviour
{
  [SerializeField] public GameObject msgPanel;
  //public GameObject my;

  static Animator anim;

  public GameObject uriel;
  private move move;


        // Start is called before the first frame update
    void Awake()
    {
        GetComponent<Collider>();
        move = uriel.GetComponent<move>();
       
    }
    void Start(){
        msgPanel.SetActive(false);
        
    }
    // Update is called once per frame
    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player"){
         msgPanel.SetActive(true);
         if(this.tag == "enemy"){
             move.setSpeed(0f);
             move.rotacion=0;
         }
        
         }
        }
    

        void OnTriggerExit(Collider other)
    {
        if(other.tag == "Player"){
         msgPanel.SetActive(false);
          this.GetComponent<Collider>().enabled = false;
          move.setSpeed(2f);
        }
    }
}