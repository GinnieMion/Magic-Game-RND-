using UnityEngine;

public class MouseReset : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }

}
// nothing else here, just unlocking the mouse!! ^^