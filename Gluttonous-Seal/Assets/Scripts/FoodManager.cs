using UnityEngine;
using System.Collections;

public class FoodManager : MonoBehaviour 
{
	public GameObject food;
	public float spawnTime = 5f;
	public Transform[] spawnPoints;

	// Use this for initialization
	void Start () 
	{
		InvokeRepeating ("Spawn", spawnTime, spawnTime);
	}
	
	// Update is called once per frame
	void Spawn() 
	{
		int spawnPointIndex = Random.Range (0, spawnPoints.Length);

		Instantiate (food, spawnPoints[spawnPointIndex].position, Quaternion.identity);
	}
}
