using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

    public GameObject shot;
    public Transform shotSpawn;
    public Cardboard player;

    Animator animator;

	// Use this for initialization
	void Start () {

        animator = transform.Find("Head").Find("Main Camera").Find("Gun_2").GetComponent<Animator>();

	}
	
	// Update is called once per frame
	void Update () {

        AudioSource audio = GetComponent<AudioSource>();

        if (player.Triggered){
            animator.SetTrigger("FIRE");
            Instantiate(shot, shotSpawn.position, shotSpawn.rotation);
            audio.Play();
        }
        
	}
}
