using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {

	public float speed;
	public GameObject cam;
	public Rigidbody rb;
	public GameObject ifThisWorksIllCry; //I crid
	private int lives; 

	private Vector3 target;
	public Vector3 camPos;

	// Use this for initialization
	void Start() {

		camPos = cam.transform.position;

		target = camPos - transform.position;
		target.Normalize();
		rb = GetComponent<Rigidbody> ();
		rb.velocity = target * speed;

		transform.LookAt (target);

		//Debug.Log (lives);
	}
	
	// Update is called once per frame
	void Update () {
		if (Vector3.Distance (transform.position, camPos) < 1) {
			Destroy(ifThisWorksIllCry);
		}
	}

	public void setLives(int l){
		lives = l;
	}

	public void decLive(){
		lives--;
	}

	public void setSpeed(float s){
		speed = s;
	}
}
