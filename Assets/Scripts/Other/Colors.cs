using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colors : MonoBehaviour
{
    public List<Color32> colors;
    Color32 red = new Color32(255, 0, 0, 255);
    Color32 blue = new Color32(0, 0, 255, 255);
    Color32 green = new Color32(0, 255, 0, 255);
    Color32 yellow = new Color32(255, 255, 0, 255);
    Color32 purple = new Color32(160, 32, 240, 255);
    Color32 orange = new Color32(255, 140, 0, 255);
    Color32 pink = new Color32(255, 105, 180, 255);

    private void OnEnable()
    {
        colors = new List<Color32>();
        colors.Add(red);
        colors.Add(blue);
        colors.Add(green);
        colors.Add(yellow);
        colors.Add(purple);
        colors.Add(orange);
        colors.Add(pink);
    }
}
