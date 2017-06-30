using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddScoreOnTriggerEnter : MonoBehaviour
{
	public int amount = 100;

	void OnTriggerEnter()
	{
		GameManager.instance.AddScore (amount);
	}
}
