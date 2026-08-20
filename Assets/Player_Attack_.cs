using JetBrains.Annotations;
using UnityEngine;

public class Player_Attack_ : MonoBehaviour
{
    [SerializeField] Animator animator;

    private bool isAnimating = false;

    private void Start()
    {
        animator = GetComponent<Animator>();
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
}
