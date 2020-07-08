using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class KartStats : MonoBehaviour
{
    [Tooltip("Velocidad maxima que tendra el kart")]
    [SerializeField] [Range(0,20)] float speed;
    [Tooltip("Aceleracion del kart")]
    [SerializeField] [Range(0,30)] float aceleration;
    [Tooltip("Desaceleracion del kart")]
    [SerializeField] [Range(0,10)] float desaceleration;
    [SerializeField] Slider velocitySlider;
    [SerializeField] Slider acelerationSlider;
    [SerializeField] Slider desacelerationSlider;

    private void Start() {
        velocitySlider.value = speed/20f;
        acelerationSlider.value = aceleration/30f;
        desacelerationSlider.value = desaceleration/10f;
    }

    public void SaveConfiguration(){

        PlayerData.SpeedKart = velocitySlider.value * 20;
        PlayerData.AcelerationKart = acelerationSlider.value * 30;
        PlayerData.DesacelerationKart = desacelerationSlider.value * 10;
        SceneManager.LoadScene("Time Trial");
    }
}
