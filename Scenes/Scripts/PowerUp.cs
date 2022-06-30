using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour {

    public GameObject pickupEffect;

    public float multiplier = 1.4f;

    void OnTriggerEnter (Collider other)
    {
        if(other.CompareTag("Player"))
        {
            Pickup(other);
        }

        void Pickup(Collider player)
        {
            Instantiate(pickupEffect, transform.position,transform.rotation);

            player.transform.localScale *= multiplier;

            Debug.Log("Power up picked up!");
           
           Destroy(gameObject);
        }
 
    }
}

    