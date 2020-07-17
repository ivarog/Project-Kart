using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WayPoint : MonoBehaviour
{
    private MyGameManager myGameManager;

    private void Start() {
        myGameManager = GameObject.FindObjectOfType<MyGameManager>();
    }

    //If object in trigger is player then add waypoint count and destroy the actual waypoint
    private void OnTriggerEnter(Collider other) {
        if(other.gameObject.tag == "Player"){
            myGameManager.AddWayPointReached();
            Destroy(gameObject);
        }
    }
}
