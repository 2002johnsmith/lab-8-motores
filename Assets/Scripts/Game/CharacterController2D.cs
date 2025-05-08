using UnityEngine;
using System;
using UnityEngine.InputSystem;

public class CharacterController2D : MonoBehaviour
{
    Rigidbody2D rb;
    [SerializeField] private float Velocity;
    Vector2 Movment;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.linearVelocity=new Vector2(Movment.x*Velocity, Movment.y*Velocity);
    }
    public void OnMovement(InputAction.CallbackContext Context)
    {
        Movment=Context.ReadValue<Vector2>();
    }
}
