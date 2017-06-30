using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayScore : MonoBehaviour
{
	public Text scoreText;
	public Text highScoreText;

	// Update is called once per frame
	void Update ()
	{
		scoreText.text = "Score: " + GameManager.instance.score.ToString();
		highScoreText.text = "High: " + GameManager.instance.highScore.ToString();
	}
}
