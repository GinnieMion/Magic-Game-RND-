using UnityEngine;
using TMPro;

public class NewSpell : MonoBehaviour

{
    string spellone = "Fireballuh";
    string spelltwo = "Wateruh";
    string spellthree = "Winduh";
    string spellfour = "Rockuh";

    public GameObject MenuPanel;
    bool opentosee = false;

    // i didnt use openpanel here since I didn't want the variables to end up clashing the code later on.

    void Start()
    {
        MenuPanel.SetActive(false);
    }

    void Update()
    {
        
    }

    // for one button
    public void buttonclick()
    {
        Debug.Log("Click recognised.");
        if (opentosee == false)
        {
            MenuPanel.SetActive(true);
            opentosee = true;
        }
        else
        {
            MenuPanel.SetActive(false);
            opentosee = false;
        }
    }


}