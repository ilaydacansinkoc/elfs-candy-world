using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateSpikes : MonoBehaviour {

    public GameObject obj;
    public float spawnTime = 7.5f;
    private GameObject instantiatedObj;

	// Use this for initialization
	void Start () {
        InvokeRepeating("SpawnCoins", spawnTime, spawnTime);
	}
	
	// Update is called once per frame
	void Update () {

    }

    void SpawnCoins()
    {
        int objNum = Random.Range(5, 7);
        for (int i = 0; i < objNum; i += 1)
        {
            float randomY = Random.Range(0, 10);
            Vector3 position = new Vector3(Random.Range(-13,13), 5 + randomY, 0);
            instantiatedObj = Instantiate(obj, position, Quaternion.identity);
            Destroy(instantiatedObj, 8);
           
        }

       

    }


}
