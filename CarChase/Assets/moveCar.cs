using UnityEngine;
using System.Collections;

public class moveCar : MonoBehaviour {

	int speed;
	// Use this for initialization
	void Start () {
		speed = 3;
	}
	
	// Update is called once per frame
	void Update () {
		transform.localPosition += transform.forward * speed * Time.deltaTime;
	}
}
