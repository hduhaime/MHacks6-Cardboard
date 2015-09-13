using UnityEngine;
using Facebook;
using System.Collections;

public class FacebookLogin : MonoBehaviour {
    private void SetInit()
    {
        enabled = true;
        // "enabled" is a magic global; this lets us wait for FB before we start rendering
    }

    private void OnHideUnity(bool isGameShown)
    {
        if (!isGameShown)
        {
            // pause the game - we will need to hide
            Time.timeScale = 0;
        }
        else
        {
            // start the game back up - we're getting focus again
            Time.timeScale = 1;
        }
    }
	public void login()
    {
        FB.Init(SetInit, OnHideUnity);
        FB.Login();
    }
}
