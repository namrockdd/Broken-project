using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeponSwap : MonoBehaviour
{
    [SerializeField] GameObject[] weapons;
    
    int WeaponQuan;
    int activeWeapon = 0;
    int lastWeapon;

    void Start()
    {
        WeaponQuan = weapons.Length;
        lastWeapon = activeWeapon;
    }

    void Update()
    {
        if(Input.GetAxis("Mouse ScrollWheel") > 0f)
        {
            lastWeapon = activeWeapon;

            activeWeapon++;
            if(activeWeapon >= WeaponQuan) activeWeapon = 0;
            
            weapons[lastWeapon].SetActive(false);
            weapons[activeWeapon].SetActive(true);
        }
        else if(Input.GetAxis("Mouse ScrollWheel") > 0f)
        {
            lastWeapon = activeWeapon;

            activeWeapon --;
            if(activeWeapon <= 0) activeWeapon = WeaponQuan - 1;

            weapons[lastWeapon].SetActive(false);
            weapons[activeWeapon].SetActive(true);
        }
    }










}
