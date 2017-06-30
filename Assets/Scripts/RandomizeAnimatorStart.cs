using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomizeAnimatorStart : MonoBehaviour
{
	private Animator animator;

	// Use this for initialization
	void Start ()
	{
		animator = GetComponent<Animator> ();
		animator.Play (animator.GetCurrentAnimatorStateInfo (0).fullPathHash, -1, Random.value);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
