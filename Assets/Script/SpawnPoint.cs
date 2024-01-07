using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    [SerializeField] private float _unitSpeed;
    [SerializeField] private Mover _cube;

    public float UnitSpeed => _unitSpeed;
    public Mover Cube => _cube;
}
