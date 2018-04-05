using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomMove : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void randomMove()
    {
        float x = Random.Range(-5f, 5f);
        float z = Random.Range(-5f, 5f);
        transform.position = new Vector3(x, 1f, z);
    }
}
