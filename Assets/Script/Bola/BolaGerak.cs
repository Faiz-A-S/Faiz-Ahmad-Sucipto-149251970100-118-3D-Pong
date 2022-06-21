using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BolaGerak : MonoBehaviour
{
    public Vector3 kecepatan;
    public Rigidbody ball;

    // Start is called before the first frame update
    void Start()
    {
        ball = GetComponent<Rigidbody>();
        ball.AddForce(kecepatan, ForceMode.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
