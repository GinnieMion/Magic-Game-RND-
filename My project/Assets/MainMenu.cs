using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // I decided to keep many of these debug logs to show how I kept error-checking and fine-tuning for any bugs.
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.M))
        {
            Debug.Log("Getting M key");
            SceneManager.LoadScene("MenuScene");
            // WHY YOU NO WORK?? edit -- nvm it works
            Debug.Log("Successful.");
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }
    }

    // this void update must be announced before any public or private void, this is an addition.
    public void startButton()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void settings()
    {

    }
    public void quit()
    {
        Application.Quit();
    }

    
}
