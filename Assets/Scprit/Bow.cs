using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bow : MonoBehaviour
{
    public float maxPower;
    public float chargePower;
    public float chargeSpeed;
    private Transform muzzle;

    public bool isCharge;

    public Rigidbody arrowModel;


    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            isCharge = true;
        }

        if (isCharge && chargePower <= maxPower)
        {
            chargePower += chargeSpeed * Time.deltaTime;
        }

        if(Input.GetMouseButtonUp(0))
        {
            Rigidbody shotArrow = Instantiate(arrowModel, muzzle.position, muzzle.rotation);
            shotArrow.AddForce(transform.forward * chargePower, ForceMode.Impulse);

            chargePower = 0f;
            isCharge = false;
        }
    }
}
