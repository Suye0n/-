using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jumper2 : MonoBehaviour {

    

    // Use this for initialization

    void OnCollisionEnter(Collision collision)
    {
        Vector3 direction = new Vector3(0, 500.0f * Time.deltaTime, 0);
        direction = direction.normalized * 500;
        collision.gameObject.GetComponent<Rigidbody>().AddForce(direction);

    }

    void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {

        
    }
}