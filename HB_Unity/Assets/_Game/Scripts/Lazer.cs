using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class Lazer : MonoBehaviour
{
	[SerializeField] LayerMask layerMask;
	void Update ()
	{
		RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.down, 5f, layerMask);
		if (hit.collider != null)
		{
			Debug.Log("The ray hit something");
			SpriteRenderer sr = hit.collider.GetComponent<SpriteRenderer>();
			if (sr != null )
			{
				sr.color = new Color(Random.value, Random.value, Random.value);
			}
			Debug.DrawLine(transform.position, transform.position + Vector3.down * 5f, Color.red);
		}
		else
		{
			Debug.Log("The ray hit nothing");
			Debug.DrawLine(transform.position, transform.position + Vector3.down * 5f, Color.green);
		}
	}
}
