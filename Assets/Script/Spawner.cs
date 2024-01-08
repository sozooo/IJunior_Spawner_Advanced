using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField, Min(1)] private float _timer;

    private List<SpawnPoint> _spawnPoits = new List<SpawnPoint>();

    private void Awake()
    {
        foreach (Transform child in transform)
        {
            _spawnPoits.Add(child.GetComponent<SpawnPoint>());
        }
    }

    private void Start()
    {
        StartCoroutine(Spawn());
    }

    private IEnumerator Spawn()
    {
        int randomPoint = Random.Range(0, _spawnPoits.Count);

        _spawnPoits[randomPoint].Spawn();

        yield return new WaitForSeconds(_timer);

        StartCoroutine(Spawn());
    }

}
