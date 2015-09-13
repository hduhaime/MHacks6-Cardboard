using UnityEngine;
using System.Collections;

public class ResetGame : MonoBehaviour {

    public Cardboard player;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (player.Triggered) Application.LoadLevel("Henry_FIX");
    }
}
