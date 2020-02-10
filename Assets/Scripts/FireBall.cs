using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBall : MonoBehaviour
{

	public GameObject fireBall;
	public GameObject fireParticles;

	public float coolDown = 5;

	float endTime = 0;

	RaycastHit hit;

	void Start()
	{
		endTime = Time.time + coolDown;
	}

    // Update is called once per frame
    void Update()
    {
        if (Time.time >= endTime)
		{
			endTime = Time.time + coolDown;

			if (Physics.Raycast(transform.position + Vector3.down, Vector3.down, out hit))
			{

				Instantiate(fireParticles, hit.point, Quaternion.LookRotation(Vector3.up));


			}

		}
    }
}
