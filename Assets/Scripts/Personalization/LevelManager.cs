using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class LevelManager : MonoBehaviour
{
    [Tooltip("Kart Material")]
    [SerializeField] Material kartMaterial;
    [Tooltip("Kart to modify")]
    [SerializeField] GameObject kart;
    [Tooltip("Canvas Configuration")]
    [SerializeField] GameObject canvasConfiguration;
    [Tooltip("Canvas Stats")]
    [SerializeField] GameObject canvasStats;
    
    private SkinnedMeshRenderer kartMesh;
    private GameObject[] wheelArray;
    private Mesh selectedMesh;

    private void Start() {
        wheelArray = GameObject.FindGameObjectsWithTag("Wheel");
    }

    private void Update() {
        kart.transform.Rotate(0f, 5f * Time.deltaTime, 0f);
    }

    /*Called when in the GUI you change the color of the kart*/
    public void ChangeColor(){
        kartMaterial.color = EventSystem.current.currentSelectedGameObject.GetComponent<Image>().color;
    }

    /*Called when in the GUI you change the wheel of the kart*/
    public void ChangeWheel(){
        selectedMesh = EventSystem.current.currentSelectedGameObject.GetComponent<WheelButton>().wheelModel;
        foreach(GameObject wheel in wheelArray)
        {
            wheel.GetComponent<MeshFilter>().mesh = selectedMesh;
        }
    }

    /*When click on button OK the configuration saves in static class Player Data*/
    public void SaveConfiguration(){
        PlayerData.ColorKart = kartMaterial.color;
        PlayerData.MeshKart = selectedMesh;
        canvasConfiguration.SetActive(false);
        canvasStats.SetActive(true);
    }
}

