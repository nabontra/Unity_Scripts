using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animatetrigger : MonoBehaviour {

    

    // Use this for initialization
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    

    //2
    void OnTriggerEnter(Collider other)
    {
        var animator = gameObject.GetComponent<Animator>();
        animator.SetTrigger("box");
        
    }

    void OnTriggerExit(Collider other)
    {
        var animator = gameObject.GetComponent<Animator>();
        animator.SetTrigger("box");
    }
}