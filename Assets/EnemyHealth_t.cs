using System.Collections;
using Unity.VisualScripting;
using UnityEngine;

public class EnemyHealth_t : MonoBehaviour
{
    [SerializeField] private int health = 2;
   
   public Sprite Sprite;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TakeDamage( int damage )
    {
        health -= damage;

        
        if ( health <= 0 )
        {
          StartCoroutine(ColorChange());
        }

    }

    private void Die()
    {
       
        Destroy(gameObject);
    }

    IEnumerator ColorChange()
    {
        GetComponent<SpriteRenderer>().color = Color.red;
        yield return new WaitForSeconds(4f);

        Die();
    }
}
