using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalController : MonoBehaviour
{
    public List<GameObject> ball;
    public bool gawangP1;
    public bool gawangP2;
    public bool gawangP3;
    public bool gawangP4;
    public ScoreManager manager;
    public BallCarrier script;
    public GameObject boldes;

    void Start()
    {
        Time.timeScale = 1;
    }
    private void OnTriggerEnter(Collider collision)
    {
        if(gawangP1)
        {
        manager.AddP1Score(1);
        }
        else if(gawangP2)
        {
        manager.AddP2Score(1);
        }
        else if(gawangP3)
        {
        manager.AddP3Score(1);
        }
        else
        {
        manager.AddP4Score(1);
        }
    }
}
