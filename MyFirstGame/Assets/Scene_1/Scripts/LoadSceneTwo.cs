using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadSceneTwo : MonoBehaviour {

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            Application.LoadLevel("scene_2");
        }
    }


}
