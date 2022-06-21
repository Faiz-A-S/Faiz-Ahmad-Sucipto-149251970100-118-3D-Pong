using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleGerak : MonoBehaviour
{
    public float kecepatan;
    public KeyCode right;
    public KeyCode left;
    public KeyCode maju;
    public KeyCode mundur;

    private Rigidbody paddle;

    // Start is called before the first frame update
    void Start()
    {
        paddle = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        MovePaddle(GetInput());
    }

    private Vector3 GetInput()
    {
        if(Input.GetKey(right))
        {
            return Vector3.right * kecepatan;
        }
        if(Input.GetKey(left))
        {
            return Vector3.left * kecepatan;
        }
        if(Input.GetKey(maju))
        {
            return Vector3.forward * kecepatan;
        }
        if(Input.GetKey(mundur))
        {
            return Vector3.back * kecepatan;
        }
        return Vector3.zero;
    }
    private void MovePaddle(Vector3 input)
    {
        paddle.velocity = input;
    }
}
