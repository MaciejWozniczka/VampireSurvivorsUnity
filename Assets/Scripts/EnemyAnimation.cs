using UnityEngine;

public class EnemyAnimation : MonoBehaviour
{
    public Transform sprite;
    public float speed;
    public float minSize;
    public float maxSize;
    private float activeSize;
    void Start()
    {
        activeSize = maxSize;
        sprite.localScale = new Vector3(maxSize, maxSize, maxSize);

        speed = Random.Range(0.5f, 1f);
    }

    void Update()
    {
        sprite.localScale = 
            Vector3.MoveTowards(sprite.localScale,
                new Vector3(activeSize, activeSize, activeSize),
                speed * Time.deltaTime);

        if (sprite.localScale.x == activeSize)
        {
            if (activeSize == maxSize)
            {
                activeSize = minSize;
            }
            else
            {
                activeSize = maxSize;
            }
        }
    }
}
