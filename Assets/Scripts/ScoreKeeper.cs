using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreKeeper : MonoBehaviour {

    public IntergerVariable score;
    public BoolVariable Collect;
    public Text scoreText;
    public Text highScoreText;
    public Text CollectText;

	// Use this for initialization
	void Start ()
    {
        score.Value = 0;
        highScoreText.text = "HighScore" + "\n" + PlayerPrefs.GetInt("HighScore", 0).ToString();
    }
	
	// Update is called once per frame
	void Update ()
    {
        scoreText.text = "Score" + "\n" + score.Value;
        if (Collect.Value)
        {
            CollectText.text = "Collect";
            CollectText.color = Color.green;
        }
        else
        {
            CollectText.text = "Avoid";
            CollectText.color = Color.red;
        }
        if(Input.GetKeyDown(KeyCode.D))
            PlayerPrefs.DeleteAll();
    }

    public void ChangeScore(int value)
    {       
        score.Value += value;
        if (score.Value > PlayerPrefs.GetInt("HighScore", 0))
        {
            PlayerPrefs.SetInt("HighScore", score.Value);
            highScoreText.text = "Highscore " + score.Value.ToString();
        }
    }
}
