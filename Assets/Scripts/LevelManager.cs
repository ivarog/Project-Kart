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
    
    private SkinnedMeshRenderer kartMesh;

    private void Update() {
        kart.transform.Rotate(0f, 5f * Time.deltaTime, 0f);
    }

    public void ChangeColor(){
        kartMaterial.color = EventSystem.current.currentSelectedGameObject.GetComponent<Image>().color;
    }
}

