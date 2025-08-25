using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public int score = 0;
    public int keys = 0;
    public int totalKeys = 3;
    public float time = 0f;

    //public TMP_Text scoreText;

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //method used to count coins collected
    public void AddScore(int s)
    {
        score += s;
        Debug.Log(score);
        //scoreText.text = "" + score;
    }
}
