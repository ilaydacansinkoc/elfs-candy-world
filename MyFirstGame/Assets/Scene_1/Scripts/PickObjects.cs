using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickObjects : MonoBehaviour {


    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag == "candy")
        {
            Debug.Log("Collided");
            Destroy(col.gameObject);
        }
    }
}
