using System;
using UnityEngine;
using UnityEngine.Events;

public class TriggerEvent : MonoBehaviour
{
    public UnityEvent triggerEnterEvent;

    private void OnTriggerEnter(Collider col)
    {
        triggerEnterEvent.Invoke();
        Debug.Log("You have entered");
    }
}
