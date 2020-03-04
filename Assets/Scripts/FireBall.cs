using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBall : MonoBehaviour
{
	public GameObject fire;
	public GameObject explosion;
	public float speed = 5;
	public float decayTime = 5;
	float startTime;

    // Start is called before the first frame update
    void Start()
    {
		startTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
		if (Time.time < startTime + decayTime)
		{
			transform.position += transform.forward * speed * Time.deltaTime;
		}
		else
			Destroy(gameObject);
    }


	void OnTriggerEnter(Collider other)
	{
		if (explosion != null)
		{
			Instantiate(explosion, transform);
		}

		Instantiate(fire, transform.position, new Quaternion());

		Destroy(gameObject, 3);
	}

}
