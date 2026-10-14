using UnityEngine;

public class Moneta : MonoBehaviour
{

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == ("Player"))
        {
            UIManager UIManager = FindAnyObjectByType<UIManager>();
            if (UIManager != null)
            {
                UIManager.AddCoin(1);
            }
            Destroy(gameObject);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        
    }
}
