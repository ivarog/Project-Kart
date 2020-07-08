using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class LevelManager : MonoBehaviour
{
    [Tooltip("Material que utilizará el carrito")]
    [SerializeField] Material kartMaterial;
    [Tooltip("Carrito a modificar")]
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

    //Cambiar color al dar click en el boton en pantalla
    public void ChangeColor(){
        kartMaterial.color = EventSystem.current.currentSelectedGameObject.GetComponent<Image>().color;
    }

    //Cambiar llanta al dar click en el boton en pantalla
    public void ChangeWheel(){
        selectedMesh = EventSystem.current.currentSelectedGameObject.GetComponent<WheelButton>().wheelModel;
        foreach(GameObject wheel in wheelArray)
        {
            wheel.GetComponent<MeshFilter>().mesh = selectedMesh;
        }
    }

    public void SaveConfiguration(){
        PlayerData.ColorKart = kartMaterial.color;
        PlayerData.MeshKart = selectedMesh;
        canvasConfiguration.SetActive(false);
        canvasStats.SetActive(true);
    }
}

