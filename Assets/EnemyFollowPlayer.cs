using UnityEngine;

public class EnemyFollowPlayer : MonoBehaviour
{
    [SerializeField] float followDistance = 1.0f;
    [SerializeField] float stopFollowDistance = 2.0f;
    [SerializeField] float speed = 0.2f;

    private Transform player;
    public bool following;

    void Start()
    {
      player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector2.Distance(transform.position, player.position);

        if(!following &&  distance <= followDistance )
        {
            following = true;
        }
        if(following && distance >= stopFollowDistance)
        {
            following = false;
        }
        if (following)
        {
            FollowPlayer();
        }


        void FollowPlayer()
        {
            Vector2 direction = (player.position - transform.position).normalized;
            transform.position += (Vector3)direction * speed * Time.deltaTime;
        }
    }
}
