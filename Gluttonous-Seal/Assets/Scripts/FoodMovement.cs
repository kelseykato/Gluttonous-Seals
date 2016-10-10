using UnityEngine;
using System.Collections;

public class FoodMovement : MonoBehaviour {

	public float speed;
	Vector3 moveDirection = new Vector3(-1, 0, 0);
	bool movingLeft = false;

	// Use this for initialization
	void Start () {


	}
	
	// Update is called once per frame
	void Update () {

		if (transform.localPosition.x == 7) {
			moveDirection = new Vector3 (-1, 0, 0);
		}
		if (transform.localPosition.x == -7) {
			moveDirection = new Vector3 (1, 0, 0);
		}
		if (!movingLeft && transform.localPosition.x >= 7) {
			moveDirection = new Vector3 (-1, 0, 0);
			movingLeft = true;
		}
		if (movingLeft && transform.localPosition.x <= -7) {
			moveDirection = new Vector3 (1, 0, 0);
			movingLeft = false;
		}

		transform.Translate (speed * Time.deltaTime * moveDirection);
	

	}

}
			
		
