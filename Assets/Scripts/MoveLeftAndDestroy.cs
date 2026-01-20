using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeftAndDestroy : MonoBehaviour
{
    [SerializeField] private float _speed = 4f;
    [SerializeField] private float _destroyX = -12f;

    private void Update()
    {
        transform.position += Vector3.left * _speed * Time.deltaTime;

        if (transform.position.x < _destroyX)
        {
            Destroy(gameObject);
        }
    }
}