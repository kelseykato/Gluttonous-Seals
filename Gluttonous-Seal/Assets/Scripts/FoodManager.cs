using UnityEngine;
using System.Collections.Generic;

public class FoodManager : MonoBehaviour 
{
	public GameObject food;
	public float spawnTime = 5f;
	public Transform[] spawnPoints;
	public List<GameObject>spawnPointsList;

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
		spawnPointsList.Add (food);
	}
	void checkDistance() {
		var player = GameObject.FindGameObjectWithTag ("MainCharacter");
		foreach (GameObject food in spawnPointsList) {
			float distance = Vector3.Distance (player.transform.position, food.transform.position);
			if (distance < 0.3f) {
				spawnPointsList.Remove (food);
				Debug.Log ("WTF");
				Destroy (food);
			}
		}
	}
}
