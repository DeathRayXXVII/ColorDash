using System;
using Unity.VisualScripting;
using UnityEngine;

public class ObjectMove : MonoBehaviour
{
    public float speed;
    private float moveVelocity;
    private Rigidbody2D rigidbody2D;

    private void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
    }
    

    private void Update()
    {
        rigidbody2D.velocity = new Vector2(-speed, rigidbody2D.velocity.y);
        moveVelocity = speed;
    }
}
