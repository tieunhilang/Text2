using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    public Button Level1;
    public Button Level2;
    public Button Level3;

    public void Start()
    {
        Level1.onClick.AddListener(LoadLevel1);
        Level2.onClick.AddListener(LoadLevel2);
        Level3.onClick.AddListener(LoadLevel3);
    }

    public void LoadLevel1()
    {
        SceneManager.LoadScene("Level1");
    }
    public void LoadLevel2()
    {
        SceneManager.LoadScene("Level2");
    }
    public void LoadLevel3()
    {
        SceneManager.LoadScene("Level3");
    }
}
