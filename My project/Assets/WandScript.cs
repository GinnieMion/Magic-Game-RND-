using JetBrains.Annotations;
using System.Collections;
using UnityEngine;

public class WandScript : MonoBehaviour
{
    public Transform SpellSpawnPoint;
    public GameObject SpellPrefab;
    public float spellSpeed = 100;
    public bool cooldown;
    public float delayTime = 0.5f;

    // cross-referncing

    public GameObject GameMenu;
    private HotbarAndHealth spellscript;

    // adding spells
    public GameObject Fireballuh;
    public GameObject Wateruh;
    public GameObject Earthrockuh;
    public GameObject Winduh;

    private void Awake()
    {
        GameObject Hotbar = GameObject.Find("GameMenu");
        // finds this stuff

        if (Hotbar != null)
        {
            spellscript = Hotbar.GetComponent<HotbarAndHealth>();
        }

       
    }

    void Update()
    {


        if (enabled)
        {
            if (Input.GetKeyUp(KeyCode.Mouse0) && !cooldown)
            {
                cooldown = true;
                Findspell();
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
    public void Findspell()
    {
        int slot = spellscript.slot;
        Debug.Log("The current slot is" + slot);
        if (slot == 1)
        {
            SpellPrefab = Fireballuh;
        }
        if (slot == 2)
        {
            SpellPrefab = Wateruh;
        }
        if (slot == 3)
        {
            SpellPrefab = Earthrockuh;
        }
        if (slot == 4)
        {
            SpellPrefab = Winduh;
        }
    }
    public void Spellassigner()
        {

        }
}
