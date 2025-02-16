using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.UI;


public class score_script : MonoBehaviour
{   
    public static score_script instance;
    public Text scoreText;
    public GameObject ScoreObject;
    public Text FinalScore;
    public int  myScore = 0;
    // Update is called once per frame
    private void Awake()
    {
        instance = this;
    }
    void Start(){
        // scoreText = GetComponent<Text>();
    }
    void Update()
    {   
        // Debug.Log("Score");
        scoreText.text = myScore.ToString();
        FinalScore.text ="Score: " + scoreText.text;
    }
    // public void AddScore(int score){
    //     myScore = myScore + score;
    // }
}
