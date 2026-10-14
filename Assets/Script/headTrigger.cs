using UnityEngine;

public class headTrigger : MonoBehaviour
{
    public Enemy owner;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            owner.Die();
        }
    }
}
