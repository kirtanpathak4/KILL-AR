using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class BulletScript : MonoBehaviour {
    //  public GameObject col;
    // Use this for initialization
    public static int score;
    public Text scoreText;
    //TextScript ts = new TextScript();
    void Start () {
        score = 0;
        SetScoreText ();

    }

	
	// Update is called once per frame
	void Update () {
        //ts.ScoreTest(score);
		
	}
    //TextScript ts=new TextScript();
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "enemy")
        {
            Destroy(collision.gameObject);
            score=score + 1;
            SetScoreText ();
            gameObject.SetActive(false);
        }
    }

    public void SetScoreText()
    {
        scoreText.text = "Score:" + score.ToString ();
    }



}
