using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UI : MonoBehaviour
{
    public void StartButton() {
        SceneManager.LoadScene(1);
    }
    public void HoHumMode() {
        SceneManager.LoadScene(2);
    }
}
