using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    [SerializeField] private float _unitSpeed;
    [SerializeField] private Mover _cube;
    [SerializeField] private Transform _target;

    public void Spawn()
    {
        Mover clone = Instantiate(_cube, transform);

        clone.StartMoving(_target, _unitSpeed);
    }
}
