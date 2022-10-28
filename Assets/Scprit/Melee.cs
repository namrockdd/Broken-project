using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Melee : MonoBehaviour
{
    [SerializeField] float distance;
    [SerializeField] int damage;
    [SerializeField] Transform face; 
    RaycastHit hit;



    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            if(Physics.Raycast(transform.position, transform.forward, out hit , distance))
            {
                if(hit.transform.tag == "Enemy")
                {
                    Enemy enemy;
                    enemy = hit.transform.GetComponent<Enemy>();

                    enemy.TakeDamage(damage);
                }
            }
        }
    }

    








}
