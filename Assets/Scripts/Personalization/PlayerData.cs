using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public static class PlayerData
{
    private static Color colorKart;
    public static Color ColorKart 
    {
        get 
        {
            return colorKart;
        }
        set 
        {
            colorKart = value;
        }
    }

    private static Mesh meshKart;
    public static Mesh MeshKart 
    {
        get 
        {
            return meshKart;
        }
        set 
        {
            meshKart = value;
        }
    }

    private static float speedKart;
    public static float SpeedKart 
    {
        get 
        {
            return speedKart;
        }
        set 
        {
            speedKart = value;
        }
    }

    private static float acelerationKart;
    public static float AcelerationKart 
    {
        get 
        {
            return acelerationKart;
        }
        set 
        {
            acelerationKart = value;
        }
    }

    private static float desacelerationKart;
    public static float DesacelerationKart 
    {
        get 
        {
            return desacelerationKart;
        }
        set 
        {
            desacelerationKart = value;
        }
    }

}