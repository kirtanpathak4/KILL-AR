using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{

    float bulletSpeed = 12300;
    public GameObject bullet;

    AudioSource bulletAudio;

    // Use this for initialization
    void Start()
    {

        bulletAudio = GetComponent<AudioSource>();

    }

    public void Fire()
    {
        //Shoot
        GameObject tempBullet = Instantiate(bullet, transform.position, transform.rotation) as GameObject;
        Rigidbody tempRigidBodyBullet = tempBullet.GetComponent<Rigidbody>();
        tempRigidBodyBullet.AddForce(tempRigidBodyBullet.transform.forward * bulletSpeed);
        Destroy(tempBullet, 2.0f);

        //Play Audio
        bulletAudio.Play();

    }
   
   
    // Update is called once per frame
   void Update()
    {
       // if(Input.touchCount==1&&Input.GetTouch(0).phase==TouchPhase.Began)
        if (Input.GetMouseButtonDown(0))
        {
          
        Fire();
        }

    }

}
