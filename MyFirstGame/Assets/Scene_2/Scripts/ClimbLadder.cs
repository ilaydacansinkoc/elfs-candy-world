using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClimbLadder : MonoBehaviour {

    public GameObject obj;
    private Player player;
    private Rigidbody2D rb2d;
    public float speed;

	// Use this for initialization
	void Start () {
        rb2d = obj.GetComponent<Rigidbody2D>();
        player = gameObject.GetComponent<Player>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    
    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "ladder")
        {
            rb2d.gravityScale = 45.0f;
        }
    }

    private void OnTriggerStay2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "ladder")
        {
            rb2d.gravityScale = 0.0f;
            float vertical = Input.GetAxis("Vertical");
            rb2d.velocity = new Vector2(rb2d.velocity.x, vertical * speed);
            Debug.Log("Trigger Stay.");
        }
        
    }

    private void OnTriggerExit2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "ladder")
        {
            rb2d.gravityScale = 2.0f;
            player.grounded = true;
            player.canDoubleJump = true;
            Debug.Log("Trigger Exit.");
        }
    }


}
