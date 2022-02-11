using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMover : MonoBehaviour
{
    [SerializeField] Vector3 finishPosition;
    [SerializeField] float speed;

    void Update()
    {
        Move();
    }

    private void Move()
    {
        transform.position = Vector3.MoveTowards(transform.position, finishPosition, speed * Time.deltaTime);
    }
}
