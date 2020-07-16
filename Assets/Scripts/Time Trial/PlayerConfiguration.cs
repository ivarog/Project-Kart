using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using KartGame.KartSystems;

public class PlayerConfiguration : MonoBehaviour
{
    [Tooltip("Script for car statistics settings")]
    [SerializeField] ArcadeKart arcadeKart;
    [Tooltip("Kart to modify")]
    [SerializeField] GameObject kart;
    [Tooltip("Material to be used by the cart")]
    [SerializeField] Material kartMaterial;
    private GameObject[] wheelArray;

    //default values ​​if not provided
    float speedDefault = 2f;
    float acelerationDefault = 3f;
    float dsacelerationDefault = 1f;
    [Tooltip("Default wheel")] [SerializeField]  Mesh defaultWheel;

    //Initialize the car stats according to the saved settings
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
