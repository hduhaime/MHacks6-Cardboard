using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

    Animator animator;

    public GameObject shot;
    public Transform shotSpawn;
    public Cardboard player;
	// Use this for initialization
	void Start () {
        animator = transform.Find("Head").Find("Main Camera").Find("Gun_2").GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        if (player.Triggered){
            animator.ResetTrigger("ShotFire");
            animator.SetTrigger("ShotFire");
            Instantiate(shot, shotSpawn.position, shotSpawn.rotation);
            
        }
        
	}
}
