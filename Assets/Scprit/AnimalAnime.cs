using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalAnime : MonoBehaviour
{
    private Animator ani;


    void Awake()
    {
        ani = GetComponent<Animator>();
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.A))
        {
            ani.SetBool("Iswalked", true);
        }

        if(Input.GetKeyUp(KeyCode.A))
        {
            ani.SetBool("Iswalked", false);
        }

        if(Input.GetKeyDown(KeyCode.S))
        {
            ani.SetBool("IsFlyed", true);
        }

        if(Input.GetKeyUp(KeyCode.S))
        {
            ani.SetBool("IsFlyed", false);
        }
    }


}
