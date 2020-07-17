using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeRing : MonoBehaviour
{
    //Countdown Clock
    ClockTimer clock;

    //Particle system when iten is grabed
    [SerializeField] ParticleSystem confeti;

    private void Start() {
        clock = GameObject.FindObjectOfType<ClockTimer>();
    }

    //Rotate ring
    private void Update() {
        transform.Rotate(0f, 5f * Time.deltaTime, 0f);
    }

    private void OnTriggerEnter(Collider other) {
        //If object is player then add 5 seconds, destroy item and throw confetti
        if(other.gameObject.tag == "Player"){
            clock.AddTime(5);
            Destroy(gameObject);
            confeti.transform.position = transform.position;
            confeti.Play();
        }
    }
}
