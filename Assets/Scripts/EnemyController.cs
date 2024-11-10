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
    }
}