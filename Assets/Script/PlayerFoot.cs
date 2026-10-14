using UnityEngine;

public class PlayerFoot : MonoBehaviour
{
    public Player player;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Platform")
        {
            player.SetGrounded(true);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag  =="Platform")
        {
            player.SetGrounded(false);
        }

    }
}
