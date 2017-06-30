using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
	public int score;
	public int highScore;

	public void AddScore (int amount)
	{
		score += amount;
		if(score > highScore)
		{
			highScore = score;
		}
	}

	public static GameManager instance;

	// Use this for initialization
	void Start ()
	{
		instance = this;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
