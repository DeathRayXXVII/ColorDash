using UnityEngine;

[CreateAssetMenu]
public class vector3Data : ScriptableObject
{
    //making a vector 3 variable
    public Vector3 value;

    public void SetValue(Vector3 v3)
    {
        value = v3;
    }
    
    //updating the position
    public void UpdateValue(Transform obj)
    {
        value = obj.position;
    }
    //updating the local position
    public void UpdateTransform(Transform obj)
    {
        obj.localPosition = value;
    }
}
