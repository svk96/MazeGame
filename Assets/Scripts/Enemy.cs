using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

    //Members 
    public float health = 1.0f;
	
	// Update is called once per frame
	void Update () {
		if(health <= 0)
        {
            Die();
        }
	}
    void Die()
    {
        //print("Enemy dies " + this.gameObject.name);
        Destroy(this.gameObject);
    }
}
