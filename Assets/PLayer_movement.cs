using UnityEngine;

public class PLayer_movement : MonoBehaviour
{
    [SerializeField] float speed = 1.0f;
   
   
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");

        Vector2 direction = new Vector2(x, y).normalized;
        transform.position += (Vector3)(direction * speed * Time.deltaTime);
     
    }
}
