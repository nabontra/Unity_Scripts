using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundtrigger : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    void OnTriggerEnter(Collider other)
    {
        AudioSource audio = GetComponent<AudioSource>();
        if (!audio.isPlaying)
            {
            audio.Play();
        }
    }

    // Update is called once per frame
    void Update () {

        

    }
}
