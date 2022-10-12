using System;
using System.Collections;
using UnityEngine;

public class TransformBehaviours : MonoBehaviour
{
    public vector3Data v3data;
    private WaitForFixedUpdate wffu = new WaitForFixedUpdate();
    public BoolData canRun;
    
    public void ResetToZero()
    {
        transform.position = Vector3.zero;
    }

    public void SetV3Value()
    {
        v3data.value = transform.position;
    }

    public void StartSendTrnasform()
    {
        canRun.value = true;
        StartCoroutine(SendTransform());
    }

    private IEnumerator SendTransform()
    {
        while (canRun.value)
        {
            SetV3Value();
            yield return new WaitForFixedUpdate();
        }
    }
}
