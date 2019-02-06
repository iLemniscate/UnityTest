using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text scoreText;
    private float time = 0f;
    // Update is called once per frame
    void Update()
    {
        time += 0.1f;
        scoreText.text = time.ToString("0");
    }
}
