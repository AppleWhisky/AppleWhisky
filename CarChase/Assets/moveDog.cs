using UnityEngine;
using System.Collections;


public class moveDog : MonoBehaviour {

	GameObject doge;

	int speed;
	// Use this for initialization
	void Start () {
		speed = 5;
		doge = GameObject.FindGameObjectWithTag ("Doge");
	}
	
	// Update is called once per frame
	void Update () {
		transform.localPosition += transform.forward * speed * Time.deltaTime;

		if (doge.transform.position.x < -1) {
			// Nothing Happens
		} else {
			if (Input.GetKeyDown (KeyCode.LeftArrow)) {
				transform.Translate(Vector3.left*(2));
			}
		}

		if (doge.transform.position.x > 1) {
			// Nothing Happens
		} else {
			if (Input.GetKeyDown (KeyCode.RightArrow)) {
				transform.Translate(Vector3.left*(-2));
			}
		}
	}
}
