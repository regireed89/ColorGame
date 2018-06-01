using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colors : MonoBehaviour
{

    public List<Color> colors;
    Color red = new Color(255, 0, 0, 255);
    Color blue = new Color(0, 0, 255, 255);
    Color green = new Color(0, 255, 0, 255);
    Color yellow = new Color(255, 255, 0, 255);
    Color purple = new Color(255, 0, 200, 255);
    Color orange = new Color(255, 125, 0, 255);
    Color pink = new Color(255, 127, 206, 255);

    // Use this for initialization
    void Start()
    {
        colors = new List<Color>();
        colors.Add(red);
        colors.Add(blue);
        colors.Add(green);
        colors.Add(yellow);
        colors.Add(purple);
        colors.Add(orange);
        colors.Add(pink);
    }

}
