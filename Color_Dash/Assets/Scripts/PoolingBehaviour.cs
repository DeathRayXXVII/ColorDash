using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolingBehaviour : MonoBehaviour
{
    public List<Transform> poolList;
    private WaitForSeconds wfsObj;
    public float seconds = 2f;
    private int i;
    public vector3Data vector3Data;
   
    IEnumerator Start()
    {
        wfsObj = new WaitForSeconds(seconds);
        while (true)
        {
            yield return wfsObj;
            poolList[i].position = vector3Data.value;
            poolList[i].gameObject.SetActive(true);
            i++;
            if (i > poolList.Count-1)
            {
                i = 0;
            }
        }
        
    }
}
