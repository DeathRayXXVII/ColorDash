using System;
using UnityEngine;
using UnityEngine.Events;

public class TriggerEvent : MonoBehaviour
{
    public UnityEvent triggerEnterEvent;
    public LayerMask coin;

    private void OnTriggerEnter(Collider col)
    {
        if (coin == LayerMask.NameToLayer("Coin"))
        {
            
            Debug.Log("You have entered");
        }
        triggerEnterEvent.Invoke();
        
    }
}
