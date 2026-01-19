using UnityEngine;

public class Spell : MonoBehaviour
{
    public float life = 5;

    void Awake()
    {
        Destroy(gameObject,life);
     
    }
    private void OnTriggerEnter(Collider other)
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