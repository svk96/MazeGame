using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

    // Members
    public float moveSpeed = 7.0f;
    private float maxDistance = 0.0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
        maxDistance += 1 * Time.deltaTime;
        if(maxDistance >= 5)
        {
            Destroy(this.gameObject);
        }
	}
}
