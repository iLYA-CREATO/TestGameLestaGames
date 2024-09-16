using System;
using UnityEngine;

public class DeadPlayer : MonoBehaviour
{
    public static event Action OnDeathPlayer;
    public void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Bottom")
        {
            Time.timeScale = 0;
            OnDeathPlayer?.Invoke();    
        }
    }
}
