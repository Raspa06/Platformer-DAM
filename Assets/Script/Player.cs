using UnityEngine;
using static UnityEngine.InputSystem.InputAction;

public class Player : MonoBehaviour
{
    public Vector2 speed;
    public float JumpForce = 200;
    public Rigidbody2D Body2D;

    bool IsGrounded = false;
    Vector2 currentSpeed;
void Start()
    {
         
    }
void Update()
    {
       
    }
public void PlayerInput_Move(CallbackContext callback)
    {
        Vector2 input = callback.ReadValue<Vector2>();
        currentSpeed = new Vector2(input.x * speed.x, 0);    

    }
    public void PlayerInput_Jump(CallbackContext callback)
    {
        if (callback.performed)
        {
            if (IsGrounded)
            {
                Body2D.AddForce(new Vector2(0, JumpForce));
            }
        }
    }
    private void FixedUpdate()
    {
        Body2D.linearVelocityX = currentSpeed.x;
    }
    
    public void SetGrounded(bool _isGrounded)
    {
        IsGrounded = _isGrounded;
    }
    
 
}
