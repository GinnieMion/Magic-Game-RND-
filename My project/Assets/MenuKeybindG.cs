using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class MenuKeybindG : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject MenuPanel;
    public GameObject SpellMenu;
    public GameObject SpellPanel;
    bool openpanel = false;
    // MenuPanel is for the External menu/canvas. The main hotbar in game
    // OpenPanel checks if the panel is open or not
    // SpellMenu is for the actual spellmenu
    private void Start()
    {
        MenuPanel.SetActive(true);
        SpellMenu.SetActive(false);
    }
    // why does the panel keep glitchign what
    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.G))
        {
            SpellMenu.SetActive(true);


            if (openpanel == false)
            {
                Debug.Log("You went to the Spell Menu");
                MenuPanel.SetActive(false);
                // affects the visibility of the panel, true means shown.
                openpanel = true;
                SpellMenu.SetActive(true);

                Cursor.visible = true;
                Cursor.lockState = CursorLockMode.None;
            }
            else
            {
                Debug.Log("You left the Spell Menu");
                goBack();
            }
        }
    }
        public void goBack()
        {
        MenuPanel.SetActive(true);
        openpanel = false;
        SpellMenu.SetActive(false);
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;


        }
}