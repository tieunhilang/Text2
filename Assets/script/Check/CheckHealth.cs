using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CheckHealth : MonoBehaviour
{
    public int health = 10;

    public Text textHealth;

    public int minus;
    



    public void Update()
    {
        checkHealth();
        if (health <= 0)
        {
            gameOver();
        }
    }

    public void Health()
    {
        health -= minus;
    }

    public void checkHealth()
    {
        textHealth.text = "Health: " + health.ToString();
    }

    public void OnTriggerEnter(Collider Egg)
    {
        if (Egg.tag == "Egg1")
        {
            minus = 1;
            Health();
            Destroy(Egg.gameObject);
        }
        if (Egg.tag == "Egg2")
        {
            Health();
            minus = 1;
            Destroy(Egg.gameObject);
        }

        if (Egg.tag == "Egg3")
        {
            Health();
            minus = 1;
            Destroy(Egg.gameObject);
        }
        if (Egg.tag == "Egg4")
        {
            Health();
            minus = 1;
            Destroy(Egg.gameObject);
        }
        if (Egg.tag == "Egg5")
        {
            Health();
            minus = 1;
            Destroy(Egg.gameObject);
        }
    }

    public void gameOver()
    {
        
        
            SceneManager.LoadScene("GameOver");
        
    }
}
