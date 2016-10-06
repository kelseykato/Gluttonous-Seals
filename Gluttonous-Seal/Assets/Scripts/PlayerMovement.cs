using UnityEngine;
using System.Collections;


public class PlayerMovement : MonoBehaviour {

	public float speed;

	void Start() {
	}

	void Update () 
	{
		var mousePosition = Camera.main.ScreenToWorldPoint (Input.mousePosition);
		float step = speed * Time.deltaTime;
		transform.position = Vector3.MoveTowards (transform.position, mousePosition, step);
	}
}
