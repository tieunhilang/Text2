using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class GameOver : MonoBehaviour
{
    public Button restartButton;
    public Button menuButton;

    public void Start()
    {
        restartButton.onClick.AddListener(restartGame);
        menuButton.onClick.AddListener(menuGame);
    }

    public void restartGame()
    {
        SceneManager.LoadScene("PlayGame");
    }

    public void menuGame()
    {
        SceneManager.LoadScene("Start");
    }
}
