using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecendPlayer : MonoBehaviour
{
    Vector2 movement;
    public float Speed = 10;
    public Rigidbody2D rb;

    private void Update() {
        movement.y = Input.GetAxisRaw("Vertical");
    }

    void FixedUpdate() {
        rb.MovePosition(rb.position - movement * Speed * Time.fixedDeltaTime);
    }
}
