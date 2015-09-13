using UnityEngine;
using System.Collections;

public class Mover : MonoBehaviour {

    public float speed;
	public GameObject gc;

	// Use this for initialization
	void Start () {
        GetComponent<Rigidbody>().velocity = transform.forward * speed;
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Enemy") {
			Destroy (other.transform.root.gameObject);
			Destroy (transform.root.gameObject);
			GameObject.FindGameObjectWithTag("GameController").GetComponent<ScoreDisplay>().addPoints(10);
		}	
	}
	

}
