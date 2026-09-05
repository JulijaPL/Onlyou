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

    public EnemyFollowPlayer stunned;
    private bool isDead = false;
    void Start()
    {
     
        Spriterenderer = GetComponent<SpriteRenderer>();
        originalColor = Spriterenderer.color;
        pool = FindFirstObjectByType<EnemyPool>();
        stunned = FindFirstObjectByType<EnemyFollowPlayer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TakeDamage( int damage )
    {
       // if( !isDead ) return;

        health -= damage;

        
        if ( health <= 0 )
        {
        //  isDead = true;
           stunned.isStunned = true;
            StartCoroutine(ColorChange());
        }

    }

    private void Die()
    {
      
     Spriterenderer.color = originalColor;
        stunned.isStunned = false;
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
        //isDead = false;
    }
}
