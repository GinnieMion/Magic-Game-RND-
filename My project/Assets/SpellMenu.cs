using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SpellMenu : MonoBehaviour
{
    private bool open = false;
    public GameObject MenuPanel;
    // looks for the game object in unity.

    public void slotOne()
    {
        if (open == false)
        {
            MenuPanel.SetActive(true);
            // affects the visibility of the panel, true means shown.
            open = true;
        }
        else
        {
            MenuPanel.SetActive(false);
            open = false;
        }
    }
    public void LeaveNow()
    {
        SceneManager.LoadScene("SampleScene");
    }
}


