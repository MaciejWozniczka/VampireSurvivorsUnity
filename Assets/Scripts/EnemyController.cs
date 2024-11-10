using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public Rigidbody2D theRigibody;
    public float moveSpeed;
    private Transform target;
    void Start()
    {
        target = Object.FindFirstObjectByType<PlayerController>().transform;
    }

    void Update()
    {
        theRigibody.velocity = (target.position - transform.position).normalized * moveSpeed;

        if (target.position.x < transform.position.x)
        {
            transform.localScale = new Vector3(Mathf.Abs(transform.localScale.x), transform.localScale.y, transform.localScale.z);
        }
        else if (target.position.x > transform.position.x)
        {
            transform.localScale = new Vector3(-Mathf.Abs(transform.localScale.x), transform.localScale.y, transform.localScale.z);
        }
    }
}