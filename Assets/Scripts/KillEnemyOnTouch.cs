using UnityEngine;

public class KillEnemyOnTouch : MonoBehaviour
{
  private void OnTriggerEnter(Collider other)
  {
    if (other.CompareTag("Enemy"))
      Destroy(other.gameObject);
  }
}
