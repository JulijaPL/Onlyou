using System.Collections;
using UnityEngine;

public class SwordTakeDamage : MonoBehaviour
{
    [SerializeField] private int damage = 1;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        EnemyHealth_t enemy = other.GetComponent<EnemyHealth_t>();

        if(enemy != null)
        {
            enemy.TakeDamage(damage);
        }
    }

  
}
