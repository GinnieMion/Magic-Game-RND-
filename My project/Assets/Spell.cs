using UnityEngine;

public class Spell : MonoBehaviour
{
    public float life = 3;

    void Awake()
    {
        Destroy(gameObject,life);
    }

}
