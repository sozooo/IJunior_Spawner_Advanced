using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetMover : MonoBehaviour
{
    [SerializeField] private Transform _path;
    [SerializeField] private float _speed;

    private List<Transform> _wayPoints = new List<Transform>();
    private int _currentPoint = 0;

    private void Awake()
    {
        foreach(Transform wayPoint in _path)
        {
            _wayPoints.Add(wayPoint);
        }
    }
    
    private void Update()
    {
        Transform target = _wayPoints[_currentPoint];

        transform.position = Vector3.MoveTowards(transform.position, target.position, _speed * Time.deltaTime);

        if(transform.position == target.position)
        {
            _currentPoint++;

            if(_currentPoint >= _wayPoints.Count)
            {
                _currentPoint = 0;
            }
        }
    }
}
