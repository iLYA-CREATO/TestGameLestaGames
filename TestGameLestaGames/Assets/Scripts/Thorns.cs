using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Thorns : MonoBehaviour
{
    public static event Action<int> DamageThorns;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Health gameObject = other.gameObject.GetComponent<Health>();
            DamageThorns?.Invoke(25);
        }
    }
}
