using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    public int scoreP1;
    public int scoreP2;
    public int scoreP3;
    public int scoreP4;
    public int maxScore;
    public BallController ball;
    public Collider gawangP1;
    public Collider gawangP2;
    public Collider gawangP3;
    public Collider gawangP4;
    public GameObject P1;
    public GameObject P2;
    public GameObject P3;
    public GameObject P4;
    public GameObject playerLeft;

    public void Update()
    {
        if(playerLeft.transform.childCount == 1)
        {
            GameOver();
        }
    }

    public void AddP1Score(int increment)
    {
        scoreP1 += increment;
        ball.ResetBall();
        if(scoreP1 >= maxScore)
        {
            Dead(gawangP1,P1);
        }
    }

    public void AddP2Score(int increment)
    {
        scoreP2 += increment;
        ball.ResetBall();
        if(scoreP2 >= maxScore)
        {
            Dead(gawangP2,P2);
        }
    }

    public void AddP3Score(int increment)
    {
        scoreP3 += increment;
        ball.ResetBall();
        if(scoreP3 >= maxScore)
        {
            Dead(gawangP3,P3);
        }
    }

    public void AddP4Score(int increment)
    {
        scoreP4 += increment;
        ball.ResetBall();
        if(scoreP4 >= maxScore)
        {
            Dead(gawangP4,P4);
        }
    }

    public void Dead(Collider gawang,GameObject player)
    {
        gawang.GetComponent<Collider>().isTrigger = false;
        Destroy(player);
    }

    public void GameOver() 
    { 
        Debug.Log("SELESAI");
        //SceneManager.LoadScene("Main Menu");
    } 
}
