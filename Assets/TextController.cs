using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextController : MonoBehaviour {

    public Text text;
    private enum States { Start, Backpack, Sleep, Explore, Gaurd, Sneek, Key, Unlock, Run };
    private States CurrentState;

    // -----------------------------------------------------------------------------

    // Use this for initialization
    void Start () {

        CurrentState = States.Start;

    }

    // -----------------------------------------------------------------------------

    // Update is called once per frame
    void Update () {


        switch (CurrentState) {

            case States.Start:
                state_start();
                break;
            case States.Backpack:
                state_backpack();
                break;
            case States.Explore:
                state_explore();
                break;
            case States.Sleep:
                state_sleep();
                break;
            case States.Gaurd:
                state_gaurd();
                break;
            case States.Key:
                state_key();
                break;
            case States.Sneek:
                state_sneek();
                break;
            case States.Unlock:
                state_unlock();
                break;
            case States.Run:
                state_run();
                break;
        }


    }

    // -----------------------------------------------------------------------------

    void state_start() {

        text.text = "You are being kidnaped by the criminals in a dark room but you are willing to escape from this place.\n\n";
        text.text += "To View Your Backpack press B, for Exploring the room press E and for sleeping press S.";

        if ( Input.GetKeyDown( KeyCode.B ) ) {

            CurrentState = States.Backpack;

        } else if (Input.GetKeyDown(KeyCode.E)) {
            CurrentState = States.Explore;

        } else if (Input.GetKeyDown(KeyCode.S)) {
            CurrentState = States.Sleep;

        }

    }

    // -----------------------------------------------------------------------------

    void state_backpack() {

        text.text  = "Your Backpack is empty you need to find a key or screw driver or something else you can open the door with\n\n";
        text.text += "If you want to go back to the start press R";

        if ( Input.GetKeyDown( KeyCode.R )  ) {

            CurrentState = States.Start;

        }

    }

    // -----------------------------------------------------------------------------

    void state_explore() {

        text.text  = "You are Exploring the roon and you have found some use full thing which are listed below also your action are listed below too\n\n";
        text.text += "If you want to go back to the start press R, and for picking key press K, for looking to the Gaurd press G, for sneeking around press N.";

        if (Input.GetKeyDown(KeyCode.R)) {

            CurrentState = States.Start;

        } else if ( Input.GetKeyDown( KeyCode.G ) ){
            CurrentState = States.Gaurd;
        } else if (Input.GetKeyDown(KeyCode.N)) {
            CurrentState = States.Sneek;
        } else if (Input.GetKeyDown(KeyCode.K)) {
            CurrentState = States.Key;
        }

    }

    // -----------------------------------------------------------------------------

    void state_sleep() {

        text.text  = "YOu are in sleep mode if you are wake up follow the lines below\n\n";
        text.text += "If you want to go back to the start press R";

        if (Input.GetKeyDown(KeyCode.R))
        {
            CurrentState = States.Start;
        }
    }

    // -----------------------------------------------------------------------------

    void state_gaurd() {

        text.text = "You are looking at the Gaurd and he is sleeping right now.\n\n";
        text.text += "If you want to go back to the Explore press R";

        if (Input.GetKeyDown(KeyCode.R))
        {
            CurrentState = States.Explore;
        }

    }

    // -----------------------------------------------------------------------------

    void state_key() {

        text.text = "You have picked the key now you can open the lock.\n\n";
        text.text += "If you want to go back to the Explore press R, for opening the door press U";

        if (Input.GetKeyDown(KeyCode.R))
        {
            CurrentState = States.Explore;
        } else if ( Input.GetKeyDown(KeyCode.U) ) {

            CurrentState = States.Unlock;

        }


    }

    // -----------------------------------------------------------------------------

    void state_sneek() {

        text.text = "You are sneeking around be carefull.\n\n";
        text.text += "If you want to go back to the Explore press R.";

        if (Input.GetKeyDown(KeyCode.R))
        {
            CurrentState = States.Explore;
        }

    }

    // -----------------------------------------------------------------------------

    void state_unlock() {

        text.text = "You have unlocked the Door Congruatulation Now look at the Gaurd and Run.\n\n";
        text.text += "If you want to go back to the Explore press R, for Runing out of here press F";

        if (Input.GetKeyDown(KeyCode.R))
        {
            CurrentState = States.Explore;
        }
        else if (Input.GetKeyDown(KeyCode.F))
        {

            CurrentState = States.Run;

        }

    }

    // -----------------------------------------------------------------------------

    void state_run() {

        text.text = "You are now free to go Great job.\n\n";
        text.text += "If you want to start the game again press S";

        if (Input.GetKeyDown(KeyCode.S))
        {
            CurrentState = States.Start;
        }

    }

    // -----------------------------------------------------------------------------

}
