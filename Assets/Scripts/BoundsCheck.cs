using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoundsCheck : MonoBehaviour
{ 
    public int getOn;
    public int getOff;
    public GameObject player;
    private Vector3 initial;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    void OnTriggerEnter()
    {
        if (player.transform.position.y > getOn && player.transform.position.y < getOff);
        transform.position = initial;
    }
}