using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BolaGerak : MonoBehaviour
{
    public List<Vector3> kecepatan;
    public Rigidbody ball;
    public BallManager randomCarrier;
    public SoundManager sm;

    // Start is called before the first frame update
    void Start()
    {
        ball = GetComponent<Rigidbody>();
        int randoms = randomCarrier.randomCarrier;
        Debug.Log(randoms);
        ball.AddForce(kecepatan[randoms], ForceMode.Impulse);
    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            sm.PlayKlak();
        }
    }
}
