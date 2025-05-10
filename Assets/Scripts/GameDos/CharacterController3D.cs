using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class CharacterController3D : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField] private float Speed;
    [SerializeField] private float JumpForce;
    private bool canJump=false;
    private Vector3 Movement; 
    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }
    private void FixedUpdate()
    {
        rb.linearVelocity = new Vector3(Movement.x * Speed, rb.linearVelocity.y, Movement.z*Speed); 
        if (canJump==true )
        {
            ApplyPhysics();
            canJump = false;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Win"))
        {
            GameManager.Instance.CheckWin();
        }
    }
    public void OnMovement(InputAction.CallbackContext context)
    {
        Vector2 Direction=context.ReadValue<Vector2>();
        Movement = new Vector3(Direction.x, 0, Direction.y);
    }
    public void OnJump()
    {
        canJump = true;
    }
    public void ApplyPhysics()
    {
        rb.AddForce(new Vector3(0, JumpForce, 0), ForceMode.Impulse);
        
    }
}
