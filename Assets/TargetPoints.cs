using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TargetPoints : MonoBehaviour
{
    public static int gameScore = 0;
    public static TextMeshProUGUI scoreText;
    public int pointValue = 2;
    // Start is called before the first frame update
    void Start()
    {
        gameScore = 0;
        scoreText.text = "Score: 0";
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        gameScore += pointValue;
        scoreText.text = "Score: " + gameScore;

    }
}
