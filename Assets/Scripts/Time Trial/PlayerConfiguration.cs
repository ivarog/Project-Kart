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


    private void Start() {
        arcadeKart.baseStats.TopSpeed = PlayerData.SpeedKart;
        arcadeKart.baseStats.Acceleration = PlayerData.AcelerationKart;
        arcadeKart.baseStats.ReverseAcceleration = PlayerData.DesacelerationKart;
        kartMaterial.color = PlayerData.ColorKart;
        wheelArray = GameObject.FindGameObjectsWithTag("Wheel");
        foreach(GameObject wheel in wheelArray)
        {
            wheel.GetComponent<MeshFilter>().mesh = PlayerData.MeshKart;
        }
    }
}
