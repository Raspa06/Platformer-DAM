using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed = 2f;
    private Vector2 direction = Vector2.left;

    public Player player;
    private Rigidbody2D rb;
    private SpriteRenderer spriteRenderer;
    public float bounceForce = 8f;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        spriteRenderer = rb.GetComponent<SpriteRenderer>();
    }
    void FixedUpdate()
    {
       rb.linearVelocity = new Vector2(direction.x * speed, rb.linearVelocity.y);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Ostacolo"))
        {
            CambiaDirezione();
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Rigidbody2D playerRb = collision.gameObject.GetComponent<Rigidbody2D>();
            foreach (ContactPoint2D punto in collision.contacts)
                if (punto.normal.y < -0.5f)
                {
                    if (playerRb != null)
                    {
                        playerRb.linearVelocity = new Vector2(playerRb.linearVelocity.x, bounceForce);
                    }
                }
                else
                {
                    Destroy(player.gameObject);
                }
        }
    }
    void CambiaDirezione()
    {
        direction = -direction;
    }

    public void Die()
    {
        Destroy(gameObject);
    }

}
