using UnityEngine;

public class HotbarAndHealth : MonoBehaviour
{
    public GameObject slotone;
    public GameObject slottwo;
    public GameObject slotthree;
    public GameObject slotfour;
    public GameObject selector;
    int slot = 0;
    string thispos = "";


    public GameObject selector1;
    public GameObject selector2;
    public GameObject selector3;
    public GameObject selector4;
    void Start()
    {
        this.selector.transform.position = slotone.transform.position;
        slot = 1;
        selector1.SetActive(true);
        selector2.SetActive(false);
        selector3.SetActive(false);
        selector4.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        //string[] slots = new string[3];

        //slots[0] = "slotone";
        //slots[1] = "slottwo";
        //slots[2] = "slotthree";
        //slots[3] = "slotfour";
        if (Input.GetKeyDown(KeyCode.Q))
        {
            if (slot <= 4)
            {
                slot = slot - 1;
            }
            if (slot <= 0)
            {
                slot = 4;
            }
        }
            if (Input.GetKeyDown(KeyCode.E))
        {
            if(slot <= 4)
            {
                slot = slot + 1;
            }
            if (slot >= 5)
            {
                slot = 1;
            }


            //thispos = slots[slot];
            //Debug.Log("Slot position is" + slot);
            //this.selector.transform.position = thispos.transform.position;
        }
        if (slot == 1)
        {
                selector1.SetActive(true);
                selector2.SetActive(false);
                selector3.SetActive(false);
                selector4.SetActive(false);

        }
        if (slot == 2)
        {
            selector1.SetActive(false);
            selector2.SetActive(true);
            selector3.SetActive(false);
            selector4.SetActive(false);
        }
        if (slot == 3)
        {
            selector1.SetActive(false);
            selector2.SetActive(false);
            selector3.SetActive(true);
            selector4.SetActive(false);
        }
        if (slot == 4)
        {
            selector1.SetActive(false);
            selector2.SetActive(false);
            selector3.SetActive(false);
            selector4.SetActive(true);
        }

    }
}


