using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class move_random : MonoBehaviour
{
    NavMeshAgent nav;
    
    public float timeForNewPath;
   bool inCoRoutine;
    // Start is called before the first frame update
    void Start()
    {
        nav = GetComponent<NavMeshAgent>();

    }

    // Update is called once per frame
    void Update()
    {
        if(!inCoRoutine){
            StartCoroutine(DoSomething());
        }
    }

    Vector3 getNewRandomPosition(){
        float x = Random.Range(-20,20);
        float z = Random.Range(-20,20);
        Vector3 pos = new Vector3(x,this.transform.position.y,z);
        return pos;
    }

    IEnumerator DoSomething(){
        inCoRoutine = true;
        yield return new WaitForSeconds(timeForNewPath);
        getNewPath();
        inCoRoutine = false;
    }

    void getNewPath(){
        nav.SetDestination(getNewRandomPosition());
    }
}
