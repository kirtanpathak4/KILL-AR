using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class finalscore : MonoBehaviour {
    public Text fs;
	// Use this for initialization
	void Start () {
		fs= GetComponent<Text>();
    }
	
	// Update is called once per frame
	void Update () {
        fs.text = "Final Score: " + TextScript.scoreValue;
    }
}
