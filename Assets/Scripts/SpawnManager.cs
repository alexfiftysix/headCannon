using Extensions;
using UnityEngine;
using Random = UnityEngine.Random;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] enemies;
    public float minimumSpawnDistanceFromPlayer = 2;
    public GameObject player;

    private int _waveNumber = 1;
    private float _bounds = 15;

    private void Update()
    {
        var enemyCount = GameObject.FindGameObjectsWithTag("Enemy").Length;
        if (enemyCount == 0)
            SpawnWave();
    }

    private void SpawnWave()
    {
        for (int i = 0; i < _waveNumber; i++)
        {
            SpawnEnemy();
        }

        _waveNumber++;
    }

    private void SpawnEnemy()
    {
        var where = GetAppropriateSpawnPosition();
        var index = Random.Range(0, enemies.Length);
        var direction = where - player.transform.position;
        Instantiate(enemies[index], where, Quaternion.LookRotation(direction, direction));
    }

    private Vector3 GetAppropriateSpawnPosition()
    {
        var where = Vector3Extensions.CreateRandom(_bounds, 3);
        var distanceToPlayer = (where - player.transform.position).magnitude;
        distanceToPlayer = distanceToPlayer < 0 ? -distanceToPlayer : distanceToPlayer;
        while (minimumSpawnDistanceFromPlayer > distanceToPlayer)
        {
            where = Vector3Extensions.CreateRandom(_bounds, 3);
            distanceToPlayer = (where - player.transform.position).magnitude;
        }

        return where;
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.magenta;
        Gizmos.DrawWireSphere(player.transform.position, minimumSpawnDistanceFromPlayer);
    }
}