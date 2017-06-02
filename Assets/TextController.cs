using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextController : MonoBehaviour {

    public Text text;

	// Use this for initialization
	void Start () {

        text.text   = "You are being kidnaped by the criminals in a dark room but you are willing to escape from this place.\n\n";
        text.text  += "To View Your Backpack press B, for Exploring the room press E and for sleeping press S.";

    }
	
	// Update is called once per frame
	void Update () {

        if ( Input.GetKeyDown( "space" ) ) {

            text.text = "Like the video if you are learning new things";

        }

	}
}
