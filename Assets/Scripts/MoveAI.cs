using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveAI : MonoBehaviour
{
	public float speed = 3;
	public Transform[] waypoints;

	private int index = 0;
	private float time;

    // Start is called before the first frame update
    void Start()
    {
		time = 0;
    }

    // Update is called once per frame
    void Update()
    {
		MoveActor();

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
