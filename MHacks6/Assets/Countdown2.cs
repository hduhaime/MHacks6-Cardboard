using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Countdown2 : MonoBehaviour {

    private Text text;

    private float endTime;

    public GameObject player;

	// Use this for initialization
	void Start () {

        text = GetComponent<Text>();

        endTime = 10f;

	}
	
	// Update is called once per frame
	void Update () {


        endTime -= Time.deltaTime;

        text.text = "RETURNING TO MAIN MENU IN..." + Mathf.Ceil(endTime);

        if (endTime <= 0) Application.LoadLevel("Alex");

        

    }
}
