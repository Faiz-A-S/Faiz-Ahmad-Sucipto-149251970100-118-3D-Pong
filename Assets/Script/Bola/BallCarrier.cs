using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallCarrier : MonoBehaviour
{
    public int carrier;

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "Player 1")
        {
            carrier = 0;
        }
        if(collision.gameObject.name == "Player 2")
        {
            carrier = 1;
        }
        if(collision.gameObject.name == "Player 3")
        {
            carrier = 2;
        }
        if(collision.gameObject.name == "Player 4")
        {
            carrier = 3;
        }
    }
}
