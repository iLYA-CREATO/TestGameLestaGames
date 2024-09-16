using System;
using System.Collections;
using UnityEngine;

public class TrapCome : MonoBehaviour
{
    public static event Action<int> DamageTrapCome;
    [SerializeField] private Material materialTrig;
    [SerializeField] private Material materialRed;
    [SerializeField] private Material standartMaterialTrap;

    public bool isActivTrap = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            isActivTrap = true;
            Debug.Log("ќй!ой зашЄл");
            Health gameObject = other.gameObject.GetComponent<Health>();
            StartCoroutine(TrigTrapCome(gameObject));
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            isActivTrap = false;
            Debug.Log("ќй!ой вышел");
        }
    }
    public IEnumerator TrigTrapCome(Health gameObject)
    {
        if(isActivTrap == true)
        {
            this.gameObject.GetComponent<Renderer>().material = materialTrig;
            yield return new WaitForSeconds(1);
            this.gameObject.GetComponent<Renderer>().material = materialRed;
            
            if (isActivTrap)
            {
                DamageTrapCome?.Invoke(25);
            }
            yield return new WaitForSeconds(0.2f);
            this.gameObject.GetComponent<Renderer>().material = materialTrig;
            yield return new WaitForSeconds(5);
            this.gameObject.GetComponent<Renderer>().material = standartMaterialTrap;
        } 
    }
    // тут нужно оверлап сфера
}
