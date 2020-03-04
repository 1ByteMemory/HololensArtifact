using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagicSpell : MonoBehaviour
{

	public GameObject fireBall;
	public GameObject fireParticles;
	public GameObject explosion;

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
		Debug.Log("Casting Fire");
		Vector3 lookDirection = Camera.main.transform.forward;

		GameObject fire = Instantiate(fireBall, transform.position + (transform.forward * 0.3f), Quaternion.LookRotation(lookDirection));
		fire.GetComponent<FireBall>().fire = fireParticles;
		Debug.Log(fire);
	}


}
