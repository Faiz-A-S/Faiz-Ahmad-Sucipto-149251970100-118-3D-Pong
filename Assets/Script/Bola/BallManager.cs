using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallManager : MonoBehaviour
{
    public Transform bal;
    public GameObject ball;
    public GameObject balls;
    public float timer;
    public int interval;
    public int max;
    public List<Vector3> spawnerLoc;
    public int random;
    
    // Start is called before the first frame update
    void Start()
    {
        timer = 0;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (timer > interval) 
        { 
            Spawn(); 
            timer -= interval;
        }
    }

    public void Spawn() 
    { 
        random = Random.Range(0,spawnerLoc.Count);
        Spawn(spawnerLoc[random]); 
    }

     public void Spawn(Vector3 position) 
    { 
        if (balls.transform.childCount >= max) 
        { 
            return; 
        } 
  
        GameObject spawn = Instantiate(ball, new Vector3(position.x,position.y,position.z), Quaternion.identity, bal); 
        spawn.SetActive(true); 
 
    } 
}
