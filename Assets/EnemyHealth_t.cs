using System.Collections;
using Unity.VisualScripting;
using UnityEngine;

public class EnemyHealth_t : MonoBehaviour
{
    [SerializeField] private int maxHealth = 2;
   private int health;  
   public SpriteRenderer Spriterenderer;

    private EnemyPool pool;
    private Color originalColor;
    void Start()
    {
     
        Spriterenderer = GetComponent<SpriteRenderer>();
        originalColor = Spriterenderer.color;
        pool = FindObjectOfType<EnemyPool>();
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
       
     Spriterenderer.color = originalColor;
        pool.OnEnemyDeath(gameObject);
    }

    IEnumerator ColorChange()
    {
        Spriterenderer.color = Color.red;
        yield return new WaitForSeconds(4f);

        Die();
    }

    private void OnEnable()
    {
      
        health = maxHealth;
    }
}
