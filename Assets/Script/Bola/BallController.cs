using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public Vector3 resetPos;
    public Rigidbody ball;

    public void ResetBall()
    {
        transform.position = new Vector3(resetPos.x,resetPos.y,-2.65f);
    }
}
