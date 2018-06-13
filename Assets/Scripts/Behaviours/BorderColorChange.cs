using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BorderColorChange : MonoBehaviour
{

    private Colors color;
    public FloatVariable BorderResetTime;
    public FloatVariable BorderColorChangeTimer;
    public GameEvent ChangeBorder;

    // Use this for initialization
    void Start()
    {
        color = FindObjectOfType<Colors>();
        BorderColorChangeTimer.Value = BorderResetTime.Value;
        var rColor = Random.Range(0, color.colors.Count);
        gameObject.GetComponent<SpriteRenderer>().color = color.colors[rColor];
    }

    // Update is called once per frame
    void Update()
    {
        BorderColorChangeTimer.Value -= Time.deltaTime;
        if (BorderColorChangeTimer.Value <= 0)
        {
            ChangeBorder.Raise();
        }
    }

    public void ChangeBorderColor()
    {
        foreach (var c in FindObjectsOfType<CollectibleBehaviour>())
        {
            if (c.gameObject.GetComponent<CollectibleBehaviour>().data.Color == GetComponent<SpriteRenderer>().color)
                return;
        }
        BorderColorChangeTimer.Value = BorderResetTime.Value;
        var rColor = Random.Range(0, color.colors.Count);
        gameObject.GetComponent<SpriteRenderer>().color = color.colors[rColor];
    }

}
