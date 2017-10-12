using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jumper2 : MonoBehaviour {

    GameObject jumper3;
    // Use this for initialization

    void OnCollisionEnter(Collision collision)
    {
        Vector3 direction = jumper3.transform.position - transform.position;
        direction = direction.normalized * 1000;
        collision.gameObject.GetComponent<Rigidbody>().AddForce(direction);
    }
    void Start () {
        jumper3 = GameObject.Find("jumper3");
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
