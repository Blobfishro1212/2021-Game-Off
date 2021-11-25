using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallThrower : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed = 250;
    public bool IsDown;
    public bool IsUp;
    public bool IsLeft;
    public bool IsRight;

    void Start() {
        rb.AddForce(Vector3.right * speed);
    }
    private void OnCollisionEnter2D(Collision2D other) {
        if(IsUp == false) {
            rb.AddForce(Vector3.up * speed);
            IsDown = false;
            IsUp = true;
        }
        if(IsUp == true) {
            rb.AddForce(Vector3.down * speed);
            IsDown = true;
            IsUp = false;
        }
        if(IsLeft == true) {
            rb.AddForce(Vector3.right * speed);
            IsRight = true;
            IsLeft = false;
        }
        if(IsLeft == false) {
            rb.AddForce(Vector3.left * speed);
            IsRight = false;
            IsLeft = true;
        }
    }
}
