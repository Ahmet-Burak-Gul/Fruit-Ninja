using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMove : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;

    [SerializeField] private float minX;
    [SerializeField] private float maxX;
    [SerializeField] private float minY;
    [SerializeField] private float maxY;


    [SerializeField] private float lifeTime;

    void Start()
    {
        rb.velocity = new Vector2(
            Random.Range(minX, maxX),
            Random.Range(minY, maxY)
        );

        Destroy(gameObject, lifeTime);
    }
}
