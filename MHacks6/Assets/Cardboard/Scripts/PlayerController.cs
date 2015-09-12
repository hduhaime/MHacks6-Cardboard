using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

    public GameObject shot;
    public Transform shotSpawn;
    public Cardboard player;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        if (player.Triggered){
            Instantiate(shot, shotSpawn.position, shotSpawn.rotation);
        }
        
	}
}
