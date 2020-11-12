using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class TextScript : MonoBehaviour
{
	public static  int scoreValue = 0;
    public Text score;
    private void Start()
    {
        score = GetComponent<Text>();
    }
    void Update()
    {
		score.text = "Score : " + scoreValue;
    }

}
