using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnityEventHelper : MonoBehaviour
{
	public void InstantiatePrefab(GameObject prefab)
	{
		Instantiate(prefab, transform.position, transform.rotation);
	}

	public void DestroyGameObject(GameObject target)
	{
		Destroy (target);
	}
}
