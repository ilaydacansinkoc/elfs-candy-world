using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground : MonoBehaviour {


    private Player player;

	// Use this for initialization
	void Start () {

        player = gameObject.GetComponentInParent<Player>();
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter2D(Collider2D collider)
    {
        player.grounded = true;

    }
    void OnTriggerStay2D(Collider2D collider)
    {
        player.grounded = true;

    }
    void OnTriggerExit2D(Collider2D collider)
    {
        player.grounded = false;
    }
}
