using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public GameObject bola;
    public int timerKembali;

    private void OnTriggerEnter(Collider collision)
    {
        Destroy(bola);
    }
}
