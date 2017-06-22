using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(UnityEventHelper))]
public class UnityEventOnButtonDown : MonoBehaviour
{
	public string buttonName = "Fire1";
	public UnityEvent events;

	// Update is called once per frame
	void Update ()
	{
		if (Input.GetButtonDown(buttonName))
		{
			events.Invoke();
		}
	}
}
