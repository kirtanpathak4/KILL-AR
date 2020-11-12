using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class BulletScript : MonoBehaviour {

    public static int score = 0;
    public Text scoreText;
   
	void Start () {
        score = 0;
    }
		
	void Update () {
       
	}

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "enemy")
        {
            Destroy(collision.gameObject);
            score=score + 1;
			TextScript.currentScore = score;
            //gameObject.SetActive(false);
			Destroy(gameObject);
        }
    }
}
