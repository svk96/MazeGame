using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

    //Members 
    public float health = 1.0f;
    public float pointsGiven = 1.0f;
    public float moveSpeed = 2.0f;

    private float passedTime = 0.0f;
    private GameObject player;

    void Start()
    {
        player = GameObject.FindWithTag("Player");
    }
    // Update is called once per frame
    void Update () {

        transform.LookAt(player.transform);
        passedTime += 1 * Time.deltaTime;
        if (passedTime >= 1)
        {
            transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
        }
        
        if (health <= 0)
        {
            Die();
        }
	}
    void Die()
    {
        //print("Enemy dies " + this.gameObject.name);
        player.GetComponent<Player>().points += pointsGiven;
        Destroy(this.gameObject);
    }
}
