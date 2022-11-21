using UnityEngine;

public class DestroyOutsideBounds : MonoBehaviour
{
    public float bounds = 20;

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x > bounds || transform.position.x < -bounds || transform.position.z > bounds ||
            transform.position.z < -bounds)
            Destroy(gameObject);
    }
}