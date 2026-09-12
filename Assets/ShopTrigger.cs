using UnityEngine;

public class ShopTrigger : MonoBehaviour
{
    [SerializeField] private GameObject shopPanel;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            shopPanel.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            shopPanel.SetActive(false);
        }
    }
}
