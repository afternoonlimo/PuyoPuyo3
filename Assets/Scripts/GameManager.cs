using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {


    private int score = 0;
    public Text scoreText;
    public AudioSource bgm;

    public AudioSource LoseAS;
    public Text GameOverText;

    public int xColumn;
    public int yRow;
    public GameObject gridPrefab;

    void Start()
    {
        for (int x = 0; x < xColumn; x++)
        {
            for (int y = 0; y < yRow; y++)
            {
                GameObject chocolate = Instantiate(gridPrefab, CorrectPositon(x, y), Quaternion.identity);
                chocolate.transform.SetParent(transform);
            }
        }
    }

    public void SetScore(int line)
    {
        int currentAddScore = (int)Mathf.Pow(line,2);

        score += currentAddScore;

        if (currentAddScore > 0)
        {
            bgm.Play();
        }

        scoreText.text = "Score:" + score.ToString();
    }

    public void SetGameOver()
    {
        GameOverText.text = "GAME OVER";
        LoseAS.Play();
        Time.timeScale = 0;
        bgm.Stop();
    }

    public Vector3 CorrectPositon(int x, int y)
    {

        return new Vector3(transform.position.x - xColumn / 2f + x, transform.position.y + yRow / 2f - y);

    }
}
