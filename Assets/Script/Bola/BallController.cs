using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public GameObject bola;
    public SoundManager sm;

    private void OnTriggerEnter(Collider collision)
    {
        sm.PlayScore();
        Destroy(bola);
    }
}
