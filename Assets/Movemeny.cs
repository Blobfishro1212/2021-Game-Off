using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Movemeny : MonoBehaviour
{
    public float Speed = 10;
    public Rigidbody2D rb;
    Vector2 movement;
    public int Number1 = 0;

    void Update() {
        movement.y = Input.GetAxisRaw("Vertical");
        if(Input.GetKeyDown(KeyCode.R)) {
            SceneManager.LoadScene(Number1);
        }
    }

    void FixedUpdate() {
        rb.MovePosition(rb.position + movement * Speed * Time.fixedDeltaTime);
    }
}
