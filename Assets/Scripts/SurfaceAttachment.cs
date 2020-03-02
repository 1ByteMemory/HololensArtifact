using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SurfaceAttachment : MonoBehaviour
{
	RaycastHit hitInfo;

	public float waitTime = 3;
	public float flySpeed = 5;
	public float rayMaxDistance = 10;

	private float currentTime;

	private Vector3 prevPosition;

	private bool meshAvailable = false;
	private bool isMoveing = false;
	private Vector3 randomPosition;

	private Vector3 dirNormalized;

	private List<GameObject> spatialMeshes = new List<GameObject>();

    // Start is called before the first frame update
    void Start()
    {
		prevPosition = transform.position;

	}

	void OnDrawGizmos()
	{
		Gizmos.color = Color.magenta;
		Gizmos.DrawRay(transform.position, dirNormalized);

		Gizmos.color = Color.yellow;
		Gizmos.DrawLine(prevPosition, randomPosition);
	}

    // Update is called once per frame
    void Update()
	{

		if (!meshAvailable)
		{
			FindSpatialMeshes();
			// If the mesh was found, allow dragon to move
			if (meshAvailable)
				isMoveing = true;
		}



		// Set a random position every x seconds
		if (Time.time >= currentTime + waitTime && meshAvailable)
		{
			// Set currentTime to the current time for the timer
			currentTime = Time.time;
			//randomPosition = PickRandomMeshTransform().position;

			//SetDirNormailsed(prevPosition, randomPosition);
		}

		if (isMoveing)
		{
			MoveToPoint();
		}

    }

	public void SetDirNormailsed(Vector3 origin, Vector3 target)
	{
		dirNormalized = (target - origin).normalized;
	}


	public void MoveToPoint()
	{


		if (Vector3.Distance(randomPosition, transform.position) <= 1)
		{
			// Set a new destination and the normalised direction
			randomPosition = PickRandomMeshTransform().position;

			SetDirNormailsed(prevPosition, randomPosition);
			
			//Debug.Log("You have reached your destination");
		} else
		{
			//Debug.Log("travelling");
			transform.position += dirNormalized * flySpeed * Time.deltaTime; 
		}



		//transform.position = Vector3.Lerp(prevPosition, randomPos, Time.deltaTime);
		prevPosition = randomPosition;

	}


	public void FindSpatialMeshes()
	{

		GameObject MeshObserver;

		try
		{
			MeshObserver = GameObject.Find("Windows Mixed Reality Spatial Mesh Observer");
		}
		catch (System.NullReferenceException)
		{
			return;
		}

		if(MeshObserver != null)
		{
			for (int i = 0; i < MeshObserver.transform.childCount; i++)
			{
				spatialMeshes.Add(MeshObserver.transform.GetChild(i).gameObject);
				Debug.Log(i + ": " + spatialMeshes[i]);
			}
		

			Debug.Log("You may pass");
			meshAvailable = true;
		}



		// Pick a random position and set the travel direction to that
		randomPosition = PickRandomMeshTransform().position;
		SetDirNormailsed(prevPosition, randomPosition);

	}


	public Transform PickRandomMeshTransform()
	{
		int randomIndex = Random.Range(0, spatialMeshes.Count - 1);

		
		return spatialMeshes[randomIndex].transform;

	}


}
