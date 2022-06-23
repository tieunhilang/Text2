using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BucketController2 : MonoBehaviour
{

    public float speed = 15f;
    public float maxX = 1.5f;
    public int score = 0;

    public Text ScoreText;


    public void Start()
    {
        SetScoreText();
    }

    public void Update()
    {
        var horizon = Input.GetAxis("Horizontal");
        var movement = new Vector3(horizon * Time.deltaTime * speed, 0, 0);
        transform.position += movement;
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -maxX, maxX),
            transform.position.y, transform.position.z);

        SetScoreText();

    }

    public void addScore(int sc)
    {
        score += sc;

    }

    public void SetScoreText()
    {
        ScoreText.text = "Score: " + score.ToString();
    }


    public void textLevel()
    {
        if (score >= 150)
        {
            SceneManager.LoadScene("Start");
        }
    }

}
