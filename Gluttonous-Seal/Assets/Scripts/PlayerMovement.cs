using UnityEngine;
using System.Collections;


public class PlayerMovement : MonoBehaviour {

	public Rigidbody2D rb;

	void Start() {
		
		rb = GetComponent<Rigidbody2D>();

	}

	void FixedUpdate () 
	{
		var mousePosition = Camera.main.ScreenToWorldPoint (Input.mousePosition);
		rb.AddForce(Vector3.Normalize (mousePosition - transform.position));




	}
}
