using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WayPoint : MonoBehaviour
{
    private MyGameManager myGameManager;

    private void Start() {
        myGameManager = GameObject.FindObjectOfType<MyGameManager>();
    }

    private void OnTriggerEnter(Collider other) {
        if(other.gameObject.tag == "Player"){
            myGameManager.AddWayPointReached();
            Destroy(gameObject);
        }
    }
}
