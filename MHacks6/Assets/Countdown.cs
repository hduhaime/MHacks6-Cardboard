using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Countdown : MonoBehaviour {

    private Text text;

    private float endTime;



	// Use this for initialization
	void Start () {
	
        text = GetComponent<Text>();

        endTime = 10f;

       
    }
	
	// Update is called once per frame
	void Update () {
        if (endTime > 0)
        {
            endTime -= Time.deltaTime;

            text.text = "PLACE YOUR PHONE IN A GOOGLE CARDBOARD BECAUSE THE GAME STARTS IN " + Mathf.Ceil(endTime) + " SECONDS";
        }
        else
        {
            Application.LoadLevel("Henry_FIX");
        }
    }
}
