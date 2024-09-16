using System;
using UnityEngine;

public class WinGame : MonoBehaviour
{
    public static event Action OnWin;
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "FinishLine")
        {
            Time.timeScale = 0;
            OnWin?.Invoke();
        }
    }
}
