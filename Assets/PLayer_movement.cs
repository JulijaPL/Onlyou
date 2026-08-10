using UnityEngine;

public class PLayer_movement : MonoBehaviour
{
    [SerializeField] float speed = 1.0f;
   Rigidbody2D rb;
    Vector2 input;
   
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        input.x = Input.GetAxisRaw("Horizontal");
        input.y = Input.GetAxisRaw("Vertical");

        input = input.normalized;
     
    }

    private void FixedUpdate()
    {
        rb.linearVelocity = input * speed;
    }
}
