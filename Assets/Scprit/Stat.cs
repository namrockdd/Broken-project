using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stat : MonoBehaviour
{
    [SerializeField] private int maxHealth;
    [SerializeField] private int maxMana;
    [SerializeField] private Hpbar hpbar;

    private int health;
    private int mana;

    void Awake()
    {
        health = maxHealth;
        mana = maxMana;
        hpbar.Setup(maxHealth);
    }

    public void CalculateHealth(int value)
    {
        health += value;

        if(health >= maxHealth) health = maxHealth;
        else if (health <= 0) health = 0;
        hpbar.SetValue(health);
    }

    public void CalculateMana(int value)
    {
        mana += value;

        if(mana >= maxMana) mana = maxMana;
        else if (mana <= 0) mana = 0;
    }


    public void TakeDMGformPoison(int value)
    {
        health += value;

        if(value <= maxHealth) health = maxHealth;
        else if (value <= 0) health = 0;
    }



    #region debug
    [ContextMenu("Health/Set Health To One")]

    private void SetHealthToOne()
    {
        health = 1;
        hpbar.SetValue(health);
    }
    #endregion

    #region  debugg
    [ContextMenu("Mana/Set Mana To One")]
    private void SetManaToOne()
    {
        mana = 1;
    }
    #endregion

}
