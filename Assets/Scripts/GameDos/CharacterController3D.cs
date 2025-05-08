using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class CharacterController3D : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField] private float Speed;
    [SerializeField] private float JumpForce;
    private Vector3 Movement; 
    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void FixedUpdate()
    {
        rb.linearVelocity = new Vector3(Movement.x * Speed, rb.linearVelocity.y, Movement.z*Speed); 
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
        Debug.Log("MOVIMIENTO");
        Vector2 Direction=context.ReadValue<Vector2>();
        Movement = new Vector3(Direction.x, 0, Direction.y);
    }
    public void OnJump()
    {

    }
    public void ApplyPhysics()
    {

    }
}
