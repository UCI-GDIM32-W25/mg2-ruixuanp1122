using System.Collections;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [Header("Spawn Settings")]
    [SerializeField] private GameObject _coinPrefab;
    [SerializeField] private float _minSpawnDelay = 0.2f;
    [SerializeField] private float _maxSpawnDelay = 1.8f;

    [Header("Spawn Position")]
    [SerializeField] private float _spawnX = 12f;
    [SerializeField] private float _spawnY = 13f;
    void Start()
    {
        StartCoroutine(SpawnLoop());
    }
    private IEnumerator SpawnLoop()
    {
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(_minSpawnDelay, _maxSpawnDelay));

            Vector3 pos = new Vector3(_spawnX, _spawnY, 0f);
            Instantiate(_coinPrefab, pos, Quaternion.identity);
        }
    }
}