using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuKeybindE : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
            Debug.Log("You went to the Spell Menu");
            SceneManager.LoadScene("SpellInterface");

        }

    }
}
