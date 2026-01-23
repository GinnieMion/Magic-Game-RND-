using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;

public class Spell : MonoBehaviour
{
    public float life = 2f;
    private WandScript Wandscript;
    public GameObject GameMenu;
    private HotbarAndHealth spellscript;



    private void Awake()
    {
        GameObject Hotbar = GameObject.Find("GameMenu");
        // finds this stuff

        if (Hotbar != null)
        {
            spellscript = Hotbar.GetComponent<HotbarAndHealth>();

        }


    }

    private void OnTriggerEnter(Collider other)
    {

        {
            
            GameObject obj = GameObject.FindWithTag("Combustible");

            if (other.gameObject.tag != "Player" && other.gameObject.tag != "Combustible")
            {
                Destroy(gameObject);
            }

            if (other.gameObject.tag == "Combustible")
            {
                Destroy(gameObject);
                Destroy(obj);
            }

            
        }
    }

    private void Update()
    {
        Destroy(gameObject, life);
    }

}