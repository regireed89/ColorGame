using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreKeeper : MonoBehaviour {

    public IntergerVariable score;
    public IntergerVariable highScore;
    public Text scoreText;
    public Text highScoreText;

	// Use this for initialization
	void Start ()
    {
        score.Value = 0;
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (score.Value > highScore.Value)
            highScore.Value += 1;

        scoreText.text = "Score" + "\n" + score.Value;
        highScoreText.text = "Highscore" + "\n" + highScore.Value;
	}

    public void ChangeScore(int value)
    {
        score.Value += value;
    }
}
