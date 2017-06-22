using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
	public float speed = 6.0f;

	// Update is called once per frame
	void Update ()
	{
		transform.position += transform.forward * speed * Time.deltaTime;	
	}
}
