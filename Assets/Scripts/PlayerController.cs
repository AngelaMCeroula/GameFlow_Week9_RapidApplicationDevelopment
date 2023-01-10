using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float playerSpeed;
    public float jumpForce;
    private Rigidbody _rb;
    private bool _isGrounded;
    
    void Awake()
    {
        _rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        
        _rb.AddForce(movement * playerSpeed);
        
        if(Input.GetKey("space") && _isGrounded)
        {
            Vector3 jump = new Vector3(0.0f, jumpForce, 0.0f);
            _rb.AddForce(jump);
            _isGrounded = false;
        }
    }

    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.CompareTag("Ground"))
        {
            _isGrounded = true;
        }
    }
}
