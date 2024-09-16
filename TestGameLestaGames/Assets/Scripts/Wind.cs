using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wind : MonoBehaviour
{
    private void OnTriggerStay(Collider other)
    {
        if(other.tag == "Wind")
        {
            Vector3 move = new Vector3(2f * Time.deltaTime,0f,2f * Time.deltaTime);
            gameObject.GetComponent<CharacterController>().Move(move);
        }
    }
}
