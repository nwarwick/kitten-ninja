using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float maxSpeed = 15f; // Movement speed
	public float jumpForce = 500f; // Jump height

    public bool grounded = false; // Is the player on the ground?
    public Transform groundCheck;
    float groundRadius = 0.2f;
    public LayerMask whatIsGround;

    private bool facingRight = true;
    private Rigidbody2D rb2d;
    private Animator playerAnimator;

    // Use this for initialization
    void Start()
    {
        rb2d = gameObject.GetComponent<Rigidbody2D>();
        playerAnimator = gameObject.GetComponent<Animator>();
    }

    void Update()
    {
        if (grounded && Input.GetKeyDown(KeyCode.UpArrow))
        {
			playerAnimator.SetBool("Ground", false);
			rb2d.AddForce(new Vector2(0, jumpForce));
        }
    }

    void FixedUpdate()
    {
        // Grounded = true when on ground, false when not on ground
        grounded = Physics2D.OverlapCircle(groundCheck.position, groundRadius, whatIsGround);
        playerAnimator.SetBool("Ground", grounded);

        float move = Input.GetAxis("Horizontal");

        playerAnimator.SetFloat("Speed", Mathf.Abs(move));

        rb2d.velocity = new Vector2(move * maxSpeed, rb2d.velocity.y);

        if (move > 0 && facingRight == false)
        {
            Flip();
        }
        else if (move < 0 && facingRight == true)
        {
            Flip();
        }
    }

    // Flips the character between left and right
    void Flip()
    {
        facingRight = !facingRight;
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }
}
