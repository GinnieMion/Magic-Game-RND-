using System.Collections;
using UnityEngine;
using UnityEngine.ProBuilder.MeshOperations;

public class teleportation : MonoBehaviour
{
    public GameObject Teleport1;
    public GameObject Teleport2;
    public bool cooldown;

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject == Teleport1 && !cooldown)
        {
            cooldown = true;
            this.gameObject.transform.position = Teleport2.transform.position;
            StartCoroutine(timer());
        }
        else if (collision.gameObject == Teleport2 && !cooldown)
        {
            cooldown = true;
            this.gameObject.transform.position = Teleport1.transform.position;
            StartCoroutine(timer());
        }
    }

    public IEnumerator timer()
    {
        yield return new WaitForSeconds(2);
        cooldown = false;
    }
}
