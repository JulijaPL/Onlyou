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

   
    private bloodPool bloodPool;
    void Start()
    {
        
        Spriterenderer = GetComponent<SpriteRenderer>();
        originalColor = Spriterenderer.color;
        pool = FindFirstObjectByType<EnemyPool>();
        stunned = FindFirstObjectByType<EnemyFollowPlayer>();
        bloodPool = FindFirstObjectByType<bloodPool>();
    }

   

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TakeDamage( int damage )
    {
       // if( !isDead ) return;

        health -= damage;
        SpawnBlood();
        

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

    private void SpawnBlood()
    {
        Debug.Log("Dzia³a?");
        GameObject blood = bloodPool.UpdateBlood();
        blood.transform.position = transform.position;

        SpriteRenderer sr = blood.GetComponent<SpriteRenderer>();
        Color color = sr.color;
        color.a = 1f;
        sr.color = color;

        blood.SetActive(true);
        

        
    }
}
