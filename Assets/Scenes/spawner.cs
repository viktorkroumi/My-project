using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public float queueTime = 3f;
    private float time = 0;
    public GameObject pipes;
    public float height;

    // Update is called once per frame
    void Update()
    {
        if (time > queueTime)
        {
            GameObject spawn = Instantiate(pipes);
            spawn.transform.position = transform.position + new Vector3(3, Random.Range(-height, height), 0);

            time = 0;
        }

        time += Time.deltaTime;
    }
}