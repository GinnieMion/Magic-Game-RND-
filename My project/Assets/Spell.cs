using UnityEngine;

public class Spell : MonoBehaviour
{
    public float life = 3;

    void Awake()
    {
        Destroy(gameObject,life);
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag != "Player")
        {
            Destroy(gameObject);
        }
        

    }
}
