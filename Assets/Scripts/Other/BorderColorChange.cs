using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BorderColorChange : MonoBehaviour {

    private Colors color;
    public FloatVariable BorderResetTime;
    public FloatVariable BorderColorChangeTimer;

	// Use this for initialization
	void Start ()
    {
        color = FindObjectOfType<Colors>();
        BorderColorChangeTimer.Value = BorderResetTime.Value;
        var rColor = Random.Range(0, color.colors.Count - 1);
        gameObject.GetComponent<SpriteRenderer>().color = color.colors[rColor];
    }
	
	// Update is called once per frame
	void Update ()
    {
        BorderColorChangeTimer.Value -= Time.deltaTime;
        if (BorderColorChangeTimer.Value <= 0)
        {
            BorderColorChangeTimer.Value = BorderResetTime.Value;
            var rColor = Random.Range(0, color.colors.Count - 1);
            gameObject.GetComponent<SpriteRenderer>().color = color.colors[rColor];     
        }
    }
}
