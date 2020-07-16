using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClockTimer : MonoBehaviour
{
    //Variable used to know if the clock should start the countdown
    [HideInInspector] public bool ActiveClock {set; get;}

    [Tooltip("Time the player will have to travel the track in seconds")]
    [SerializeField] float seconds = 60f;
    //Variable that indicates if the game time has ended
    [HideInInspector] public bool TimeOut {set; get;}
    //Show time on Canvas
    private Text clock;

    void Start()
    {
        clock = gameObject.GetComponent<Text>();
        TimeOut = false;
    }

    // Update is called once per frame
    void Update()
    {
        CountDown();
        clock.text = seconds.ToString();
    }

    //The clock is counted down in case it is activated by the Gamemanager
    void CountDown(){
        if(ActiveClock ){
            seconds -= Time.deltaTime;
            if(seconds <= 0){
                TimeOut = true;  
                seconds = 0f;
            } 
        }
    }

    //Add time to the countdown
    //@param timeAmount the mount of time to add when you touch an item
    public void AddTime(float timeAmount){
        seconds+=timeAmount;
    }
}
