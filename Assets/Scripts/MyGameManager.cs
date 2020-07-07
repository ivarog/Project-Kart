using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MyGameManager : MonoBehaviour
{

    [Tooltip("Banner que se utiliza para dar instrucciones al jugador")]
    [SerializeField] GameObject banner;
    [Tooltip("Texto del banner utilizado para las instrucciones")]
    [SerializeField] Text bannerMessage;
    [Tooltip("Reloj de la cuenta regresiva")]
    [SerializeField] ClockTimer clock;


    //Variables para saber si el jugador ha alcanzado la meta
    public int wayPointsNumber {get; set;}
    public int wayPointsReached {get; set;}
    public bool goalReached {get; set;}

    void Start()
    {
        bannerMessage.text = "Reach the goal before the time runs out";
        clock.ActiveClock = true;
        StartCoroutine(HideBanner(3f));
        wayPointsNumber = FindObjectsOfType<WayPoint>().Length;
        goalReached = false;
    }   

    // Update is called once per frame
    void Update()
    {
        if(clock.TimeOut){
            bannerMessage.text = "Time Out";
            banner.SetActive(true);
            StartCoroutine(LoadNextScene(4f, "LoseScene"));
        }
        else if(goalReached){
            bannerMessage.text = "Goal Reached";
            banner.SetActive(true);
            StartCoroutine(LoadNextScene(4f, "WinScene"));
        }
    }

    IEnumerator HideBanner(float seconds)
    {
        yield return new WaitForSeconds(seconds);
        banner.SetActive(false);
    }

    //Cargar escena después del tiempo establecido
    IEnumerator LoadNextScene(float seconds, string sceneName)
    {
        yield return new WaitForSeconds(seconds);
        SceneManager.LoadScene(sceneName);
    }

    public void AddWayPointReached(){
        wayPointsReached += 1;
    }

    
}
