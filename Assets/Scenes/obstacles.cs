using System.Collections;
using System.Collections.Generic;
using UnityEditor.UIElements;
using UnityEngine;

public class obstacles : MonoBehaviour
{
    public float speed;

    // Update is called once per frame
    void Update()
    {
        float frametime = Time.deltaTime;

        transform.position += speed * Vector3.left * frametime;
    }
}