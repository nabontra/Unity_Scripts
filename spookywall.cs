using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spookywall : MonoBehaviour {

	// Use this for initialization
	void Start () {
        GameObject.Find("spookywall").transform.localScale = new Vector3(0, 0, 0);
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider collider)
    {
        GameObject.Find("spookywall").transform.localScale = new Vector3(7, 5, 1);  //I use these numbers because it is a Cube in the demo. Use (1,1,1) for any other mesh.
    }

    void OnTriggerExit(Collider collider)
    {
        GameObject.Find("spookywall").transform.localScale = new Vector3(0, 0, 0);
    }
}