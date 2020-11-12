using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Time1 : MonoBehaviour {
    private static float deltaTime;
    public float timeleft = 60f;
    public Text countdownText;
	// Use this for initialization
	void Start () {
        countdownText = GetComponent<Text>();
		
	}
	
	// Update is called once per frame
	void Update () {
        timeleft -= Time.deltaTime;
        if (timeleft > 0)
        {
            // timeleft = 0;
            countdownText.text = "Timeleft:" + Mathf.Round(timeleft);
        }
        else
        {
            SceneManager.LoadScene("Timeleftscene");
        }
		
	}
}
