using UnityEngine;
using System.Collections.Generic;

public class FoodManager : MonoBehaviour 
{

	public float spawnTime = 5f;
	public GameObject food;
	public Transform[] spawnPoints;
	public List<GameObject>FoodList;

	// Use this for initialization
	void Start () 
	{
		FoodList = new List<GameObject> ();
		InvokeRepeating ("Spawn", spawnTime, spawnTime);
	}
	
	// Update is called once per frame
	void Spawn() 
	{
		spawnPoints.ToString();
		int spawnPointIndex = Random.Range (0, spawnPoints.Length);

		GameObject foodPoop = Instantiate (food, spawnPoints[spawnPointIndex].position, Quaternion.identity)as GameObject;
		FoodList.Add (foodPoop);
		Debug.Log ("WHY");

	}

	void Update() {

		var player = GameObject.FindGameObjectWithTag ("MainCharacter");
		for (int i = FoodList.Count; i >= 0; i--) {
			float distance = Vector3.Distance (player.transform.position, food.transform.position);
			if (distance < 0.3f) {
				Destroy (FoodList[i]);
				FoodList.RemoveAt (i);
			}
		}
	}
}
