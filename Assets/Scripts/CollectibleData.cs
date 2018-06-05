using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "ScriptableObject", menuName = "Collectible Data")]

public class CollectibleData : ScriptableObject
{

    public FloatVariable speed;
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
