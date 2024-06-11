using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEditor.SceneManagement;
using UnityEditorInternal;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class death : MonoBehaviour
{
    public GameObject Image;
    public GameObject Button;

    void Start()
    {
        Image.SetActive(false);
        Button.SetActive(false);
    }

    public void GameOver()
    {
        Time.timeScale = 0;
        Image.SetActive(true);
        Button.SetActive(true);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameOver();
    }

    
    public void StartGame()
    {
        Button.SetActive(false);
        Image.SetActive(false);
        Time.timeScale = 1;

        RestartGame();
    }

    public void RestartGame()
    {
        EditorSceneManager.LoadScene(0);
    }
}