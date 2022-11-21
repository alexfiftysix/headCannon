using UnityEngine;

public class GoStraightAhead : MonoBehaviour
{
    public float speed = 5;

    void Update()
    {
        transform.Translate(Vector3.forward * (speed * Time.deltaTime));
    }
}
