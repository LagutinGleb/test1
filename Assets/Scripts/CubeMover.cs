using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMover : MonoBehaviour
{
    [SerializeField] Vector3 finishPosition;
    Vector3 startPosition;
    [SerializeField] float speed;

    public bool isGoingForward;

    private void Awake()
    {
        startPosition = transform.position;
    }

    void Update()
    {
        CheckDirection();
        Move();
    }

    private void Move()
    {
        if (isGoingForward)
            transform.position = Vector3.MoveTowards(transform.position, finishPosition, speed * Time.deltaTime);
        else
            transform.position = Vector3.MoveTowards(transform.position, startPosition, speed * Time.deltaTime);
    }

    private void CheckDirection()
    { 
        if(transform.position == startPosition)
            isGoingForward = true;
        else if(transform.position == finishPosition)
            isGoingForward = false;
    }
}
