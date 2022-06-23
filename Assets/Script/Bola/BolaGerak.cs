using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BolaGerak : MonoBehaviour
{
    public List<Vector3> kecepatan;
    public Rigidbody ball;
    public BallManager random;

    // Start is called before the first frame update
    void Start()
    {
        ball = GetComponent<Rigidbody>();
        int randoms = random.random;
        Debug.Log(randoms);
        ball.AddForce(kecepatan[randoms], ForceMode.Impulse);
    }
}
