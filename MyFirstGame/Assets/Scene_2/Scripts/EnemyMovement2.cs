using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement2 : MonoBehaviour
{

    public GameObject obj;
    static float t = 0.0f;
    private float minimum = 11.18f;
    private float maximum = 13.6f;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        obj.transform.position = new Vector3(Mathf.Lerp(minimum, maximum, t), obj.transform.position.y, obj.transform.position.z);
        t += 0.5f * Time.deltaTime;
        if (t > 1.0f)
        {
            float temp = maximum;
            maximum = minimum;
            minimum = temp;
            t = 0.0f;
        }
    }
}
