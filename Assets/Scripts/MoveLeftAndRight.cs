using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeftAndRight : MonoBehaviour
{
	public float speed = 6.0f;
	
	// Update is called once per frame
	void Update ()
	{
		transform.position += Vector3.right * speed * Input.GetAxis("Horizontal") * Time.deltaTime;
	}
}
