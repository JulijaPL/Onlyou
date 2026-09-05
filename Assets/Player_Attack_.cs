using JetBrains.Annotations;
using UnityEngine;

public class Player_Attack_ : MonoBehaviour
{
    [SerializeField] Animator animator;
    [SerializeField] Collider2D swordCollider;

   


    private bool isAnimating = false;

    private void Start()
    {
        animator = GetComponentInParent<Animator>();
        swordCollider.enabled = false;
    }
    private void Update()
    {
        if(Input.GetMouseButtonDown(0) && !isAnimating)
        {
            StartAnimation();
        }

      
    }
    void StartAnimation()
        {
            isAnimating = true;

        animator.SetTrigger("Attack");

       
    }

        public void AnimationFinished()
        {
            isAnimating = false;
        }
    public void EnableSwordDamage()
    {
        swordCollider.enabled = true;
      
    }
    public void DisableSwordDamage()
    {
        swordCollider.enabled = false;
    }
}
