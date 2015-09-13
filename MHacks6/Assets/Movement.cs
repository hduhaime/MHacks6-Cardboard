using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {

	public float speed;
	public GameObject cam;
	public GameObject gc;
	public Rigidbody rb;
	public GameObject ifThisWorksIllCry; //I crid
	private int lives; 

	private Vector3 target;
	public Vector3 camPos;

	public bool ground;

	// Use this for initialization
	void Start() {

		if (!ground) {
			camPos = cam.transform.position;
		} else {
			camPos = Vector3.zero;
		}

		target = camPos - transform.position;
		target.Normalize();
		rb = GetComponent<Rigidbody> ();
		rb.velocity = target * speed;

		transform.LookAt (target);

		//Debug.Log (lives);
	}
	
	// Update is called once per frame
	void Update () {
		if (Vector3.Distance (transform.position, camPos) < 30) {
			Destroy(ifThisWorksIllCry);
			GameObject.FindGameObjectWithTag("GameController").GetComponent<HealthBar>().TakeDamage(10);
            Handheld.Vibrate();
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
