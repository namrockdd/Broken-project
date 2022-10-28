using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private int hp;
    [SerializeField] private float speed;

    public void TakeDamage(int dmg)
    {
        hp -= dmg;
    }




}
