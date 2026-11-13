using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public float MovementSpeed =10.0f;
    public float JumpSpeed = 5.0f;
    
    
    
    
    public float groundradiuscheck;
    public Transform groundchecker;
    public LayerMask groundlayer;
    private bool isGrounded;


    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

  
    void Update()
    {
        float moveInput = Input.GetAxis("Horizontal");
        rb.linearVelocity = new Vector2(moveInput * MovementSpeed, rb.linearVelocity.y);



        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, JumpSpeed);
        }

    }

    private void FixedUpdate()
    {
        isGrounded = Physics2D.OverlapCircle(groundchecker.position, groundradiuscheck, groundlayer);
    }
}
