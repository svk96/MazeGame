using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public float health = 3.0f;
    public float moveSpeed = 7.0f;
    public float points = 0.0f;
    public GameObject bulletSpawner;
    public GameObject bullet;
    public Transform initial;
    
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //Player movement
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
            //transform.GetChild(0).LookAt(Vector3.forward, Vector3.up);
            //transform.GetChild(0).RotateAround(transform.position, transform.up, 0);
            transform.GetChild(0).rotation = Quaternion.Euler(0, 0, 0);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);
            //transform.GetChild(0).RotateAround(transform.position, transform.up, -90);
            //if(Input.GetKeyDown(KeyCode.A))
                transform.GetChild(0).rotation = Quaternion.Euler(0, -90, 0);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * moveSpeed * Time.deltaTime);
            //transform.GetChild(0).RotateAround(transform.position, transform.up, 180);
            transform.GetChild(0).rotation = Quaternion.Euler(0, 180, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);
            //transform.GetChild(0).RotateAround(transform.position, transform.up, 90);
            transform.GetChild(0).rotation = Quaternion.Euler(0, 90, 0);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Shoot();
        }
    }
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            health -= 1.0f;
            transform.Translate(initial.position, Space.World);
            if (health < 0)
            {
                print("Player died");
                /*Destroy(this.gameObject);*/
            }

        }
    }
    void Shoot()
    {
        Instantiate(bullet.transform, bulletSpawner.transform.position, bulletSpawner.transform.rotation);
    }
}
