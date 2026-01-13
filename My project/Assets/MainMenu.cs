using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.M))
        {
            SceneManager.LoadScene("MenuScene");
            Debug.Log("Successful");
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
