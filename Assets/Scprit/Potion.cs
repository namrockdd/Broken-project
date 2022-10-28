using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Potion : MonoBehaviour
{
    [SerializeField] private int power;
    [SerializeField] private float duration;
    
    [SerializeField] private Affect affect;
    [SerializeField] private PotionType type;

    private Movement playerMovement;

    void Awake()
    {
        playerMovement = new Movement();
    }

    void OnEnable()
    {
        playerMovement.Enable();
    }

    void OnDisable()
    {
        playerMovement.Disable();
    }

    void Start()
    {
        playerMovement.Player.Interract.started += _ => UsePotion();
    }

    private enum PotionType 
    {
        Health,
        Mana,
        Fireres,
        Poison
    }

    private void UsePotion()
    {
        switch(type)
            {
                case PotionType.Health:
                affect.HealthBuff(power, duration); 
                break;

                case PotionType.Mana:
                affect.ManaBuff(power, duration);
                break;

                case PotionType.Poison:
                affect.PoisonBuff(-power, duration);
                break;
            }
    }


    

    



}
