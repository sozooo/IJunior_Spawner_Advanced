using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    public void StartMoving(Transform target, float speed)
    {
        StartCoroutine(Move(target, speed));
    }

    private IEnumerator Move(Transform target, float speed)
    {
        transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);

        yield return null;

        StartCoroutine(Move(target, speed));
    }
}
