using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour
{
    public Text scoreText;
    public Text FinScore;
    public static int score = 0;
    public GameObject FinPanel;
    // Start is called before the first frame update
    void Start()
    {
       FinPanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = score.ToString();
        FinScore.text = "Your Score : " + score.ToString();
        if(score == 1000)
        {
            FinPanel.SetActive(true);
            Destroy(gameObject);
        }
    }

    public void NextLv()
    {
        Destroy(gameObject);
        FindObjectOfType<AudioManager>().Play("Button");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void Quit()
    {
        ResetScore();
        FindObjectOfType<AudioManager>().Play("Button");
        SceneManager.LoadScene(0);
    }

    public void ResetScore()
    {
        score = 0;
    }

    /*public void Fin()
    {
        if(score == 10)
        {
            FinPanel.SetActive(true);
        }
    }*/
}
