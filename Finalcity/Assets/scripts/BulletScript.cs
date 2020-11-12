using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class BulletScript : MonoBehaviour {
    
    // Use this for initialization
  
    void Start () {
       

    }

	
	// Update is called once per frame
	void Update () {
       
   	}
    
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "enemy")
        {

            TextScript.scoreValue++;
            Destroy(collision.gameObject);
            gameObject.SetActive(false);
        }
    }

   


}
