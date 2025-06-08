using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class Score : MonoBehaviour
{
    public float score;
    public TextMeshProUGUI scoreText;

    void Start()
    {
        score = 0;
    }

    void Update()
    {
        scoreText.text = score + "";
    }
}
