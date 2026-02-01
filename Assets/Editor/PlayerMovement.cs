using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float moveSpeed;
    float speedX, speedY;
    Rigidbody2D rb;



    void Start()
    {
        
        rb = GetComponent<Rigidbody2D>();

    }

    void FixedUpdate()
    {

        speedX = Input.GetAxisRaw("Horizontal") * moveSpeed;
        speedY = Input.GetAxisRaw("Vertical") * moveSpeed;
        rb.linearVelocity = new Vector2(speedX, speedY).normalized * moveSpeed;

    }
}
