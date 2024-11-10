using UnityEngine;

public class CameraController : MonoBehaviour
{
    private Transform target;

    void Start()
    {
        target = Object.FindFirstObjectByType<PlayerController>().transform;
    }

    void LateUpdate()
    {
        transform.position = new Vector3(target.position.x, target.position.y, transform.position.z);
    }
}
