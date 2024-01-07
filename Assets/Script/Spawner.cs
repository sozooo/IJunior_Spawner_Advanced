using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField, Min(1)] private float _timer;
    [SerializeField] private List<Transform> _targets;

    private List<SpawnPoint> _spawnPoits = new List<SpawnPoint>();

    private void Awake()
    {
        foreach (Transform child in transform)
        {
            _spawnPoits.Add(child.GetComponent<SpawnPoint>());
        }
    }

    void Start()
    {
        StartCoroutine(Spawn());
    }

    private IEnumerator Spawn()
    {
        int randomPoint = Random.Range(0, _spawnPoits.Count);
        Mover clone = Instantiate(_spawnPoits[randomPoint].Cube, _spawnPoits[randomPoint].transform);

        clone.StartMoving(_targets[randomPoint], _spawnPoits[randomPoint].UnitSpeed);

        yield return new WaitForSeconds(_timer);

        StartCoroutine(Spawn());
    }

}
