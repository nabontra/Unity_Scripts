using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class popuptext2 : MonoBehaviour {

    public string myString;
    public Text myText;
    public float fadeTime;
    public bool displayInfo;

    // Use this for initialization
    void Start () {

    myText = GameObject.Find ("Text2").GetComponent<Text> ();
    myText.color = Color.clear;
    //Screen.showCursor = false;
    //Screen.lockCursor = true;
}

// Update is called once per frame
void Update () {
        FadeText();

        /*if (Input.GetKeyDown (KeyCode.Escape)) 
                {
                        Screen.lockCursor = false;   
                }*/
    }

void OnTriggerEnter(Collider other)
    {
        displayInfo = true;
    }

void OnTriggerExit(Collider other)
    {
        displayInfo = false;
    }

void FadeText()
    {
        if (displayInfo)
        {
            myText.text = myString;
            myText.color = Color.Lerp(myText.color, Color.black, fadeTime * Time.deltaTime);
        }
        else
        {
            myText.color = Color.Lerp(myText.color, Color.clear, fadeTime * Time.deltaTime);
        }
    }
}
