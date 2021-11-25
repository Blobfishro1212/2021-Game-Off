using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallThrower : MonoBehaviour
{
    public Rigidbody2D rb;

    void Start() {
        rb.AddForce(Vector3.left * 250);
    }

    private void OnCollisionEnter2D(Collision2D other) {
        int Dir = Random.Range(1, 4);
        if(Dir == 1)
            rb.AddForce(Vector3.up * 250);
            Debug.Log("Up");
        if(Dir == 2)
            rb.AddForce(Vector3.down * 250);
            Debug.Log("Down");
        if(Dir == 3)
            rb.AddForce(Vector3.left * 250);
            Debug.Log("Left");
        if(Dir == 4)
            rb.AddForce(Vector3.right * 250);
            Debug.Log("Right");
    }
}
