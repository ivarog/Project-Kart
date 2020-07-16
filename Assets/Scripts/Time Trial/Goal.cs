using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    private MyGameManager myGameManager;

    private void Start() {
        myGameManager = GameObject.FindObjectOfType<MyGameManager>();
    }

    private void OnTriggerEnter(Collider other) {
        //if the player has touched the checkpoints and after the goal the race has finished
        if(other.gameObject.tag == "Player"){
            if( myGameManager.wayPointsReached >= myGameManager.wayPointsNumber){
                myGameManager.goalReached = true;
            }
        }
    }
}
