using UnityEngine;
using UnityEngine.ProBuilder.Shapes;

public class banana : MonoBehaviour
{
    public GameObject cube;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }


    // THIS ENTIRE SECTION IS JUST CLUNKY UNWORKING MOVEMENT PLEASE LORD I HATE THIS SO MUCH AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA IT WONT EVEN WORK OMDOMDOMDODMODMODMDOD

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            Debug.Log("You pressed A");
            cube.transform.Translate(1, 0, 0);
        }
        if (Input.GetKey(KeyCode.W))
        {
            Debug.Log("You pressed W");
            cube.transform.Translate(0, 1, 0);
            }
        if (Input.GetKey(KeyCode.D))
        {
             Debug.Log("You pressed D");
             cube.transform.Translate(0, 0, 0);
        }
        if (Input.GetKey(KeyCode.S))
        {
            Debug.Log("You pressed S");
            cube.transform.Translate(0, 0, 0);
        }
    }
}
