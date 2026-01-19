using UnityEngine;

public class WandScript : MonoBehaviour
{
    public Transform SpellSpawnPoint;
    public GameObject SpellPrefab;
    public float spellSpeed = 100;

    private void Start()
    {

    }
    void Update()
    {

        if (enabled)
        {
            if (Input.GetKeyUp(KeyCode.Mouse0))
            {
                var spell = Instantiate(SpellPrefab, SpellSpawnPoint.position, SpellSpawnPoint.rotation);
                spell.GetComponent<Rigidbody>().linearVelocity = SpellSpawnPoint.forward * spellSpeed;
            }
        }
    }
}
