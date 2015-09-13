using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScoreDisplay : MonoBehaviour {

    private int score = 0;

    public Canvas scoreCanvas;

    private Text scoreText;

    public Text scoreText2;


	// Use this for initialization
	public void Start () {

        scoreText = scoreCanvas.GetComponent<Text>();
        scoreText.text = scoreText2.text = "Score: 0";
    }
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown("space")) addPoints(10);

        scoreText.text = scoreText2.text = "SCORE: " + score;


    }

    public void addPoints(int points) { score += points;  
		Debug.Log ("Hit");
	}
}
