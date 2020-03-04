using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagicSpell : MonoBehaviour
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

		}
    }

	public void CastFireball()
	{
		Vector3 lookDirection = Camera.main.transform.forward;

		Instantiate(fireBall, transform.position, Quaternion.LookRotation(lookDirection));

	}


}
