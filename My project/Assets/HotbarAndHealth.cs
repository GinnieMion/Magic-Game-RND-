using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.UI;

public class HotbarAndHealth : MonoBehaviour
{

    // slots
    public GameObject slotone;
    public GameObject slottwo;
    public GameObject slotthree;
    public GameObject slotfour;

    // slots counter

    public GameObject spell;
    public int slot = 0;

    // slots end

    // selectors
    public GameObject selector1;
    public GameObject selector2;
    public GameObject selector3;
    public GameObject selector4;
    // selectors end







    // health

    [SerializeField] private Image HealthbarSprite;

    public void UpdateHealthBar(float maxHealth, float currentHealth)
    {
        HealthbarSprite.fillAmount = currentHealth / maxHealth;
    }

    // health script end


    void Start()
    {
        slot = 1;
        selector1.SetActive(true);
        selector2.SetActive(false);
        selector3.SetActive(false);
        selector4.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
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
            if (slot <= 4)
            {
                slot = slot + 1;
            }
            if (slot >= 5)
            {
                slot = 1;
            }

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
    


