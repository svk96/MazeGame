using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour {
    public GameObject wall;
	// Use this for initialization
	void Start () {
        for (int x = -16; x <= 16; x++)
        { 
            Instantiate(wall.transform, new Vector3(x, 0.5f, 16), Quaternion.identity);
            Instantiate(wall.transform, new Vector3(x, 0.5f, -16), Quaternion.identity);
        }
        for (int z = -15; z <= 15; z++)
        {
            Instantiate(wall.transform, new Vector3(16, 0.5f, z), Quaternion.identity);
            Instantiate(wall.transform, new Vector3(-16, 0.5f, z), Quaternion.identity);
        }
        for (int x = -15; x <= 15; x++)
        {
            for (int z = -15; z <= 15; z++)
            {
                if(!(x == -15 && z == -15 ||
                     x == -15 && z ==  15 ||
                     x ==  15 && z == -15 ||
                     x ==  15 && z  ==  15)
                     && Random.value < 0.15f)
                { 
                    Instantiate(wall.transform, new Vector3(x, 0.5f, z), Quaternion.identity);
                    Instantiate(wall.transform, new Vector3(x, 0.5f, z), Quaternion.identity);
                }
            }
        }

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
