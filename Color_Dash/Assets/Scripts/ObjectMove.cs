using System;
using Unity.VisualScripting;
using UnityEngine;

public class ObjectMove : MonoBehaviour
{
    public float speed;
    private float moveVelocity;
    private Rigidbody rigidbody;
    public Animation anim;

    private void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        //anim = GetComponent<Animation>();
    }
    

    private void Update()
    {
        rigidbody.velocity = new Vector2(-speed, rigidbody.velocity.y);
        moveVelocity = speed;
    }
}
