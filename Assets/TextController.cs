using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextController : MonoBehaviour {

    // ---------------------------------------------------------------------------------

    public Text text;

	// Use this for initialization
	void Start () {
        text.text = "Subscribe to internetseekho my channel to recevive notifications";
	}
	
    // ---------------------------------------------------------------------------------

	// Update is called once per frame
	void Update () {

        if ( Input.GetKeyDown( KeyCode.Space ) ) {

            text.text = "Like the video if you are learing new thing";

        }

	}

    // ---------------------------------------------------------------------------------

}
