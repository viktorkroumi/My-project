using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject scoring;
    public int score;

    public void OnTriggerEnter2D(Collider2D trigger)
    {
            score++;
    }
}
