using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class score : MonoBehaviour
{
    public static int scorecount = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        scorecount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<UnityEngine.UI.Text>().text = scorecount.ToString();
    }
}
