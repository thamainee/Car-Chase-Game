using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class ScoreManager : MonoBehaviour




{
    // Start is called before the first frame update
public static ScoreManager instance;


public TextMeshProUGUI scoreText;
int score = 0;

    private void Awake() { 
        instance = this;
    }

void Start()
    {
        scoreText.text = score.ToString() + "POINTS";

    }

    public void AddPoint()
    {
        score += 1;
        scoreText.text = score.ToString() + "POINTS";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
