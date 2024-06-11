using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scoring : MonoBehaviour
{
    public void OnTriggerEnter2D(Collider2D collision)
    {
        score.scorecount++;
    }
}
