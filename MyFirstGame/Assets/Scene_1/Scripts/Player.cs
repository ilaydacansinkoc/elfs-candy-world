using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public GameObject obj;
    private Rigidbody2D rb2d;
    private Animator anim;

    [SerializeField]
    private float movSpeed;

    public float jumpPower = 100f;
    public bool canDoubleJump=false;
    public bool grounded;

	// Use this for initialization
	void Start () {
        Debug.Log("I am alive.");
        anim = gameObject.GetComponent<Animator>();
        rb2d = gameObject.GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {

        anim.SetBool("grounded", grounded);

        float horizontal = Input.GetAxis("Horizontal");
        handleMovement(horizontal);

                 
    }

    private void handleMovement(float horizontal)
    {

        rb2d.velocity = new Vector2(horizontal * movSpeed, rb2d.velocity.y);

        if(Input.GetButtonDown("Jump")){

            if (grounded)
            {
                rb2d.AddForce(Vector2.up * jumpPower);
                canDoubleJump = true;
            }

            else
            {
                if (canDoubleJump)
                {
                    canDoubleJump = false;
                    rb2d.velocity = new Vector2(rb2d.velocity.x, 0);
                    rb2d.AddForce(Vector2.up * jumpPower);
                }
            }
        }

    }

    private void OnTriggerStay2D(Collider2D other)
    {
        if(other.gameObject.tag == "nyan")
        {
            transform.parent = other.transform;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "nyan")
        {
            transform.parent = null;
        }
    }
}
