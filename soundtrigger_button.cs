using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundtrigger_button : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    void OnTriggerStay(Collider other)
    {
        
        if (Input.GetKeyDown(KeyCode.E))
        {
            AudioSource audio = GetComponent<AudioSource>();
            if (!audio.isPlaying)
            {
                audio.Play();
            }
        }
    }

    // Update is called once per frame
    void Update () {

        

    }
}
