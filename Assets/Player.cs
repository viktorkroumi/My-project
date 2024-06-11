using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float velocity = 3f;
    public Rigidbody2D rigidbody;

    void Start()
    {
        transform.position = new Vector3(0, 2, -1);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rigidbody.velocity = Vector2.up * velocity;
        }
    }
}
