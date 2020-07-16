using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MyGameManager : MonoBehaviour
{

    [Tooltip("Banner that is used to give instructions to the player")]
    [SerializeField] GameObject banner;
    [Tooltip("Banner text used for instructions")]
    [SerializeField] Text bannerMessage;
    [Tooltip("Countdown Clock")]
    [SerializeField] ClockTimer clock;


    //Variables to know if the player has reached the goal
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
        GameConditions();
    }

    //Hide banner after seconds
    //@param seconds number of seconds before hide the pannel
    IEnumerator HideBanner(float seconds)
    {
        yield return new WaitForSeconds(seconds);
        banner.SetActive(false);
    }

    //Load scene after set time
    //@param    seconds number of seconds before load scene
    //          sceneName name of the scene to load                
    IEnumerator LoadNextScene(float seconds, string sceneName)
    {
        yield return new WaitForSeconds(seconds);
        SceneManager.LoadScene(sceneName);
    }

    //When waypoint is touched add 1 to count
    public void AddWayPointReached(){
        wayPointsReached += 1;
    }

    //Check the state of the game, if the time is up or if the goal has been reached
    private void GameConditions(){
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
}
