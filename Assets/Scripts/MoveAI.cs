using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveAI : MonoBehaviour
{
	public float speed = 3;
	public Transform[] waypoints;

	private int index = 0;
	private float time;

	private Rigidbody rb;
	public float gravitySize = 9.8f;

    // Start is called before the first frame update
    void Start()
    {
		rb = GetComponent<Rigidbody>();
		time = 0;
    }

    // Update is called once per frame
    void Update()
    {
		//MoveActor();

		CheckDirection();


    }


	void CheckDirection()
	{
		if (Input.GetKeyDown(KeyCode.W))
			ChangeGravity(Vector3.forward);

		if (Input.GetKeyDown(KeyCode.S))
			ChangeGravity(Vector3.back);

		if (Input.GetKeyDown(KeyCode.A))
			ChangeGravity(Vector3.left);

		if (Input.GetKeyDown(KeyCode.D))
			ChangeGravity(Vector3.right);

	}



	void ChangeGravity(Vector3 gravityDirection)
	{
		Debug.Log("Changing gravity to " + gravityDirection * gravitySize);
		Physics.gravity = gravityDirection * gravitySize;
	}



	void MoveActor()
	{
		if (time < 1)
		{
			if (index == waypoints.Length - 1)
				transform.position = Vector3.Lerp(waypoints[index].position, waypoints[0].position, time);
			else
				transform.position = Vector3.Lerp(waypoints[index].position, waypoints[index + 1].position, time);

			time += 0.01f * speed;

		}
		else
		{
			time = 0;
			if (index < waypoints.Length - 1)
			{
				index++;
			}
			else
			{
				index = 0;

			}
		}
	}
}
