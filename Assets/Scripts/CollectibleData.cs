using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectibleData : ScriptableObject {

    private int speed;
    private Color color;

    public int Speed
    {
        get { return speed; }
        set { speed = value; }
    }
    public Color Color
    {
        get { return color; }
        set { color = value; }
    }
}
