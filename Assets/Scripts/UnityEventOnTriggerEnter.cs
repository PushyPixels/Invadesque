using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(UnityEventHelper))]
public class UnityEventOnTriggerEnter : MonoBehaviour
{
	public UnityEvent events;
	
	// Update is called once per frame
	void OnTriggerEnter()
	{
		events.Invoke();
	}
}
