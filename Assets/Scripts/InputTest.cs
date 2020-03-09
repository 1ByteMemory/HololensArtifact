using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isRotating)
		{
			transform.eulerAngles += new Vector3(0.5f, 0, 0);
		}
    }

	bool isRotating = false;
	public void RotateCube()
	{
		isRotating = !isRotating;
	}

	public void Say(string say)
	{
		Debug.Log(say);
	}
}
