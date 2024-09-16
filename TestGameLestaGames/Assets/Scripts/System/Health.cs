using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor;
using UnityEngine;

public class Health : MonoBehaviour, IHealth, IViewHealth
{
    public static event Action OnDefeat;
    [SerializeField] private TextMeshProUGUI textHelth;


    private int health;

    private int maxHealth = 100;

    

    private void OnEnable()
    {
        Thorns.DamageThorns += Damage;
        TrapCome.DamageTrapCome += Damage;
        DeadPlayer.OnDeathPlayer += Death;
    }

    private void OnDisable()
    {
        Thorns.DamageThorns -= Damage;
        TrapCome.DamageTrapCome -= Damage;
        DeadPlayer.OnDeathPlayer -= Death;
    }

    public void Start()
    {
        health = maxHealth;
        ViewHelth(health);
    }

    public void Damage(int damage)
    {
        if(health > damage)
        {
            health -= damage;
        }
        else if(health <= damage)
        {
            health = 0;
            OnDefeat?.Invoke();
        }
        ViewHelth(health);
    }

    public void Regen(int regen)
    {
        if(health < maxHealth) 
        {
            health = maxHealth;
        }
        ViewHelth(health);
    }

    public void ViewHelth(int helth)
    {
        textHelth.text = helth.ToString();
    }

    public void Death()
    {
        health -= health;
        OnDefeat?.Invoke();
    }
}
