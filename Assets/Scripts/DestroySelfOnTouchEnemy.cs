using UnityEngine;

public class DestroySelfOnTouchEnemy : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
            Destroy(gameObject);
    }
}
