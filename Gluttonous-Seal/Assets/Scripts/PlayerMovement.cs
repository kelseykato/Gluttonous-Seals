using UnityEngine;
using System.Collections;


public class PlayerMovement : MonoBehaviour {

	public float speed;


	Vector3 newPosition;
	void Start() {
		//current character's position = (1,0)
		//mouse at (61,0)
		//in one minute we want character to move slowly
		//takes 60 sec for character to get where we clicked
		newPosition = transform.position;
	}

	void Update () 
	{
		if (Input.GetMouseButtonDown (0)) 
		{
			newPosition = Camera.main.ScreenToWorldPoint (Input.mousePosition);
		}
		transform.position = Vector2.MoveTowards (transform.position, newPosition, speed * Time.deltaTime);
	}

}
