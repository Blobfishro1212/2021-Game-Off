using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movemeny : MonoBehaviour
{
    public float Speed = 10;
    public Rigidbody2D rb;
    Vector2 movement;

    void Update() {
        movement.y = Input.GetAxisRaw("Vertical");
    }

    void FixedUpdate() {
        rb.MovePosition(rb.position + movement * Speed * Time.fixedDeltaTime);
    }
}
