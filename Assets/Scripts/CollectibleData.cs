using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "ScriptableObject", menuName = "Collectible Data")]

public class CollectibleData : ScriptableObject
{

    private float speed;
    public float Speed
    {
        get
        {
            return speed;
        }

        set
        {
            speed = value;
        }
    }

    private Color color;
    public Color Color
    {
        get
        {
            return color;
        }

        set
        {
            color = value;
        }
    }


}
