using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BorderColorChange : MonoBehaviour {

    private Colors color;
    public FloatVariable BorderResetTime;
    public FloatVariable BorderColorChangeTimer;
    public BoolVariable Collect;
    public GameEvent OnBorderChange;

	// Use this for initialization
	void Start ()
    {
        color = FindObjectOfType<Colors>();
        BorderColorChangeTimer.Value = BorderResetTime.Value;
        var rColor = Random.Range(0, color.colors.Count);
        gameObject.GetComponent<SpriteRenderer>().color = color.colors[rColor];
        var c = Random.Range(0, 1);
        if (c > 0)
            Collect.Value = true;
        else
            Collect.Value = false;


    }
	
	// Update is called once per frame
	void Update ()
    {
        BorderColorChangeTimer.Value -= Time.deltaTime;
        if (BorderColorChangeTimer.Value <= 0)
        {
            OnBorderChange.Raise();
            BorderColorChangeTimer.Value = BorderResetTime.Value;
            var rColor = Random.Range(0, color.colors.Count);
            gameObject.GetComponent<SpriteRenderer>().color = color.colors[rColor];
            var c = Random.Range(0, 1);
            if (c > 0)
                Collect.Value = true;
            else
                Collect.Value = false;
        }
    }

    public void BorderChanged()
    {
        foreach (var c in FindObjectsOfType<CollectibleBehaviour>())
        {
            c.gameObject.GetComponent<SphereCollider>().enabled = false;
        }
    }

}
