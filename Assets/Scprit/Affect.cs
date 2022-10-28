using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Affect : MonoBehaviour
{
    [SerializeField] private Stat stat;
    [Header("Health Relate Effect")]
    [Header("Mana Relate Effect")] 
    [SerializeField] private float timeBetweenHeal;

    private bool healthFXInProgress;
    private float healthFxDuration;
    private bool manaFXInProgress;
    private float manaFxDuration;
    private bool debuffFXInProgress;
    private float debuffFxDuration;
    private Coroutine healthFx;
    private Coroutine manaFX;
    private Coroutine poisonFx;
    
    void Update()
    {
        if(healthFXInProgress) healthFxDuration += Time.deltaTime;
        if(manaFXInProgress) manaFxDuration += Time.deltaTime;
        if(debuffFXInProgress) debuffFxDuration += Time.deltaTime;
    }

    public void HealthBuff(int power, float limiter)
    {
        if(healthFx != null) StopCoroutine(healthFx);

        healthFx = StartCoroutine(Adrenaline(limiter, timeBetweenHeal, power));
    }

    public void ManaBuff(int power, float limiter)
    {
        if(manaFX != null) StopCoroutine(manaFX);

        manaFX = StartCoroutine(MaNanbuff(limiter, timeBetweenHeal, power));
    }   

   public void PoisonBuff(int power, float limiter)
    {
        if(poisonFx != null) StopCoroutine(poisonFx);

        poisonFx = StartCoroutine(Debuff(limiter, timeBetweenHeal, power));
    }

    IEnumerator Adrenaline(float limiter, float timeBetweenFx, int power)
    {
        healthFxDuration = 0f;
        healthFXInProgress = true;
        while(healthFxDuration <= limiter)
        {
            stat.CalculateHealth(power);
            yield return new WaitForSeconds(timeBetweenFx);
        }
        healthFx = null;
        healthFXInProgress = false;
    }

    IEnumerator MaNanbuff(float limiter, float timeBetweenFx, int power)
    {
        manaFxDuration = 0f;
        manaFXInProgress = true;
        while(manaFxDuration <= limiter)
        {
            stat.CalculateMana(power);
            yield return new WaitForSeconds(timeBetweenFx);
        }
        manaFX = null;
        manaFXInProgress = false;
    }
    IEnumerator Debuff(float limiter, float timeBetweenFx, int power)
    {
        debuffFxDuration = 0f;
        debuffFXInProgress = true;
        while(debuffFxDuration <= limiter)
        {
            stat.CalculateHealth(power);
            yield return new WaitForSeconds(timeBetweenFx);
        }
        poisonFx = null;
        debuffFXInProgress = false;
    }




}
