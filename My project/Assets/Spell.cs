using System.Runtime.CompilerServices;
using UnityEngine;

public class Spell : MonoBehaviour
{
    public float life = 5;
    private WandScript Wandscript;


    void Awake()
    {
        Destroy(gameObject,life);

        {
        GameObject Wand = GameObject.Find("Wand");
        // finds this stuff

        if (Wand != null)
        {
            Wandscript = Wand.GetComponent<WandScript>();
        }

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

}