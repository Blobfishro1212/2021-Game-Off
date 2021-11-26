using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointsYAY : MonoBehaviour
{
    public string TextValue;
    public Text textElement;
    public int Points;

    private void Start() {
        textElement.text = "0";
    }
    private void OnTriggerEnter2D(Collider2D trigger) {
        Points += 1;
        textElement.text = Points.ToString();
    }
}
