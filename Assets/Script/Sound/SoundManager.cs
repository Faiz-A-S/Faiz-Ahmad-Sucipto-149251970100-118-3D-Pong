using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public AudioSource spawn,klak,dead,score,bg;
   
    public void PlaySpawn()
    {
        spawn.Play();
    }

    public void PlayKlak()
    {
        klak.Play();
    }

    public void PlayDead()
    {
        dead.Play();
    }

    public void PlayScore()
    {
        score.Play();
    }
}
