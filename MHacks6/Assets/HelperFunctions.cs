using UnityEngine;
using System.Collections;

public class HelperFunctions : MonoBehaviour {

	public void showInstructions()
    {
        Application.LoadLevel("HowToPlay");
    }

    public void toMainMenu()
    {
        Application.LoadLevel("Alex");
    }

    public void startGame()
    {
        Application.LoadLevel("Countdown");
    }

    public void stopGame()
    {
        Application.Quit();
    }

    public void highScore()
    {

    }
}
