using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathWalls : MonoBehaviour
{
    public int Number1 = 1;
    
    private void OnTriggerEnter2D(Collider2D trigger) {
        SceneManager.LoadScene(Number1);
    }
}
