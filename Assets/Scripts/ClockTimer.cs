using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClockTimer : MonoBehaviour
{
    //Variable utilizada para saber si el reloj debe comenzar la cuenta regresiva
    [HideInInspector] public bool ActiveClock {set; get;}

    [Tooltip("Tiempo que va a tener el jugador para recorrer la pista en segundos")]
    [SerializeField] float seconds = 60f;
    //Varable que indica si el tiempo del juego ha finalizado
    [HideInInspector] public bool TimeOut {set; get;}
    //Mustra el tiempo en el Canvas
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

    //Se realiza la cuenta regresiva del reloj en caso de que sea activada por el Gamemanager
    void CountDown(){
        if(ActiveClock ){
            seconds -= Time.deltaTime;
            if(seconds <= 0){
                TimeOut = true;  
                seconds = 0f;
            } 
        }
    }

    public void AddTime(float timeAmount){
        seconds+=timeAmount;
    }
}
