using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playmoviestart : MonoBehaviour {
    
	// Use this for initialization
	void Start () {
        ((MovieTexture)GetComponent<Renderer>().material.mainTexture).loop = true;
        ((MovieTexture)GetComponent<Renderer>().material.mainTexture).Play();
        
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
