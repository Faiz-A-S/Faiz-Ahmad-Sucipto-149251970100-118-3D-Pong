using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalController : MonoBehaviour
{
    public Collider ball;
    public bool gawangP1;
    public bool gawangP2;
    public bool gawangP3;
    public bool gawangP4;
    public ScoreManager manager;
    public BallCarrier script;

    private void OnTriggerEnter(Collider collision)
    {
        if(collision == ball)
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
}
