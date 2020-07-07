using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeRing : MonoBehaviour
{
    //Reloj de la cuenta regresiva
    ClockTimer clock;

    private void Start() {
        clock = GameObject.FindObjectOfType<ClockTimer>();
    }

    private void OnTriggerEnter(Collider other) {
        if(other.gameObject.tag == "Player"){
            clock.AddTime(5);
            Destroy(gameObject);
        }
    }
}
