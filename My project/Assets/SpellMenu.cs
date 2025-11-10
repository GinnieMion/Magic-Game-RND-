using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpellMenu : MonoBehaviour
{
    private bool open = false;
    public GameObject MenuPanel;

    public void slotOne()
    {
        if (open == false)
        {
            MenuPanel.SetActive(true);
            open = true;
        }
        else
        {
            MenuPanel.SetActive(false);
            open = false;
        }
    }
}


