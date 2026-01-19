using System.Collections;
using UnityEngine;

public class WandScript : MonoBehaviour
{
    public Transform SpellSpawnPoint;
    public GameObject SpellPrefab;
    public float spellSpeed = 100;
    public bool cooldown;
    public float delayTime = 0.5f;

    void Update()
    {

        if (enabled)
        {
            if (Input.GetKeyUp(KeyCode.Mouse0) && !cooldown)
            {
                cooldown = true;
                var spell = Instantiate(SpellPrefab, SpellSpawnPoint.position, SpellSpawnPoint.rotation);
                spell.GetComponent<Rigidbody>().linearVelocity = SpellSpawnPoint.forward * spellSpeed;
                StartCoroutine(timer());
            }
        }

    }
    public IEnumerator timer()
    {
        yield return new WaitForSeconds(delayTime);
        cooldown = false;
    }
}
