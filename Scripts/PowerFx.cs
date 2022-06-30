using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerFx : MonoBehaviour
{
    public AudioSource powerFx;

    void OnTriggerEnter(Collider other)
    {
        powerFx.Play();
        this.gameObject.SetActive(false);
    }
}
