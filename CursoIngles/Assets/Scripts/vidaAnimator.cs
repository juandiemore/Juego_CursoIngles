using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vidaAnimator : MonoBehaviour
{
    private Animator anim;
    int state = 0;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
