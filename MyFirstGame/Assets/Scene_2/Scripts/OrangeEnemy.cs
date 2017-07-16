using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrangeEnemy : MonoBehaviour
{

    private Transform trans;
    
    static float t = 0.0f;
    public float minimum;
    public float maximum;

    // Use this for initialization
    void Start()
    {
        trans = gameObject.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        trans.position = new Vector3(Mathf.Lerp(minimum, maximum, t), trans.position.y, trans.position.z);
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
