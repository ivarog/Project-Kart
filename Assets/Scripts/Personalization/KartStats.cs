using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class KartStats : MonoBehaviour
{
    [Tooltip("Top kart velocity")]
    [SerializeField] [Range(0,20)] float speed;
    [Tooltip("Kart Acceleration")]
    [SerializeField] [Range(0,30)] float aceleration;
    [Tooltip("Kart Desacceleration")]
    [SerializeField] [Range(0,10)] float desaceleration;
    [SerializeField] Slider velocitySlider;
    [SerializeField] Slider acelerationSlider;
    [SerializeField] Slider desacelerationSlider;

    private void Start() {

        //Init sliedrs
        velocitySlider.value = speed/20f;
        acelerationSlider.value = aceleration/30f;
        desacelerationSlider.value = desaceleration/10f;
    }

    /*When click on button OK the configuration saves in static class Playerr Data*/
    public void SaveConfiguration(){
        PlayerData.SpeedKart = velocitySlider.value * 20;
        PlayerData.AcelerationKart = acelerationSlider.value * 30;
        PlayerData.DesacelerationKart = desacelerationSlider.value * 10;
        SceneManager.LoadScene("Time Trial");
    }
}
