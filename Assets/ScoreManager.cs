using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {

    private int _score;
    private Text text;
	// Use this for initialization
	void Start () {
        text = this.GetComponent<Text>();
	}

    public void addScore(int scoreToAdd)
    {
        _score += scoreToAdd;
        text.text = "Score: " + _score;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
