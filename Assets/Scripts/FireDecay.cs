using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireDecay : MonoBehaviour
{
	public float decayTime = 10;

	float endTime = 0;


	void Start()
	{
		endTime = Time.time + decayTime;
	}

	// Update is called once per frame
	void Update()
	{
		if (Time.time >= endTime)
		{
			Destroy(gameObject);
		}
	}
}
