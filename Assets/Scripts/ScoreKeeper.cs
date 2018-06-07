using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreKeeper : MonoBehaviour {

    public IntergerVariable score;
    public Text scoreText;
    public Text highScoreText;

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
	}

    public void ChangeScore(int value)
    {       
        score.Value += value;
        if (score.Value > PlayerPrefs.GetInt("HighScore", 0))
        {
            PlayerPrefs.SetInt("HighScore", score.Value);
            highScoreText.text = score.Value.ToString();
        }
    }
}
