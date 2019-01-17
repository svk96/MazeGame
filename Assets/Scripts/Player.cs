﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour {

    public float health = 3.0f;
    public float moveSpeed = 7.0f;
    public float points = 0.0f;
    public GameObject bulletSpawner;
    public GameObject bullet;
    private Vector3 initial;
    private GameObject StartMenu;
    private GameObject Life;
    private GameObject Score;
    public GameObject GUI;

    public static bool GameIsPaused = false;

    // Use this for initialization
    void Start () {
        GUI = GameObject.FindGameObjectWithTag("GUI");
        StartMenu = GameObject.FindGameObjectWithTag("StartMenu");
        Life = GameObject.FindGameObjectWithTag("Life");
        Score = GameObject.FindGameObjectWithTag("Score");
        initial = transform.position;
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

        if(GUI.activeInHierarchy)
        {
            Life.GetComponent<Text>().text = health.ToString();
            Score.GetComponent<Text>().text = points.ToString();
        }
        
    }
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            health -= 1.0f;
            transform.position = initial;
            /*transform.Translate(initial.position, Space.World);*/
            if (health < 1)
            {
                print("Player died");
                /*Destroy(this.gameObject);*/
                StartMenu.SetActive(true);
                Time.timeScale = 0f;
                GameIsPaused = true;
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }

        }
    }
    void Shoot()
    {
        Instantiate(bullet.transform, bulletSpawner.transform.position, bulletSpawner.transform.rotation);
    }
}
