using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallManager : MonoBehaviour
{
    public Transform bal;
    public GameObject ball;
    public GameObject balls;
    public int intervalSpawn;
    public int maxBola;
    public List<Vector3> spawnerLoc;
    public int randomCarrier;
    public SoundManager sm;
    
    private float timer;
    // Start is called before the first frame update
    void Start()
    {
        timer = 0;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (timer > intervalSpawn) 
        { 
            Spawn(); 
            timer -= intervalSpawn;
        }
    }

    public void Spawn() 
    { 
        randomCarrier = Random.Range(0,spawnerLoc.Count);
        Spawn(spawnerLoc[randomCarrier]); 
    }

     public void Spawn(Vector3 position) 
    { 
        if (balls.transform.childCount >= maxBola) 
        { 
            return; 
        } 
        sm.PlaySpawn();
        GameObject spawn = Instantiate(ball, new Vector3(position.x,position.y,position.z), Quaternion.identity, bal); 
        spawn.SetActive(true); 
 
    } 
}
