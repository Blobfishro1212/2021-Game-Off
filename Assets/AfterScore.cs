using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AfterScore : MonoBehaviour
{
    public GameObject Ball;
    public Rigidbody2D rb;
    public float speed = 250;

    private void OnTriggerEnter2D(Collider2D other) {
        Ball.transform.position = new Vector3(0, 0, 0);
        //rb.AddForce(Vector3.up * speed);
    }
}
