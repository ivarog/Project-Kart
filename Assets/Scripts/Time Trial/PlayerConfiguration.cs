using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using KartGame.KartSystems;

public class PlayerConfiguration : MonoBehaviour
{
    [Tooltip("Script para las configuraciones de estadisticas del auto")]
    [SerializeField] ArcadeKart arcadeKart;
    [Tooltip("Carrito a modificar")]
    [SerializeField] GameObject kart;
    [Tooltip("Material que utilizará el carrito")]
    [SerializeField] Material kartMaterial;
    private GameObject[] wheelArray;

    //Default values
    float speedDefault = 2f;
    float acelerationDefault = 3f;
    float dsacelerationDefault = 1f;
    [Tooltip("Default wheel")]
    [SerializeField]  Mesh defaultWheel;

    //Inicializar las stats del auto de acuerdo a las configuraciones guardadas
    private void Start() {
        arcadeKart.baseStats.TopSpeed = PlayerData.SpeedKart <= 0f ? speedDefault : PlayerData.SpeedKart;
        arcadeKart.baseStats.Acceleration = PlayerData.AcelerationKart <= 0f ? acelerationDefault : PlayerData.AcelerationKart;
        arcadeKart.baseStats.ReverseAcceleration = PlayerData.DesacelerationKart <= 0f ? dsacelerationDefault : PlayerData.DesacelerationKart;
        kartMaterial.color = PlayerData.ColorKart == null ? Color.blue : PlayerData.ColorKart;
        wheelArray = GameObject.FindGameObjectsWithTag("Wheel");
        Mesh wheelMesh = PlayerData.MeshKart == null ? defaultWheel : PlayerData.MeshKart;
        foreach(GameObject wheel in wheelArray)
        {
            wheel.GetComponent<MeshFilter>().mesh = wheelMesh;
        }
    }
}
