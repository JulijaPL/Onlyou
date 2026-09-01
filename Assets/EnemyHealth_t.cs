using UnityEngine;

public class EnemyHealth_t : MonoBehaviour
{
    [SerializeField] private int health = 2;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void TakeDamage( int damage )
    {
        health -= damage;

        if( health <= 0 )
        {
            Die();
        }

    }

    private void Die()
    {
        Destroy(gameObject);
    }
}
