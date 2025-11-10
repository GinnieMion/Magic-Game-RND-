using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpellMenu : MonoBehaviour
{
    public bool open = false;
    public GameObject PanelThing;


    public void slotOne()
    {
        if (open == true)
        {
            PanelThing.SetActive(false);
            open = false;
        }
        else
        {
            PanelThing.SetActive(true);
            open = true;
        }
    }
}


