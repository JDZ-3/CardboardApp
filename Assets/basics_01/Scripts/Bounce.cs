using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bounce : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void bounce() { GetComponent<Rigidbody>().velocity += new Vector3(Random.Range(-5f,5f), Random.Range(0f, 5f), Random.Range(-5f, 5f)); }
}
