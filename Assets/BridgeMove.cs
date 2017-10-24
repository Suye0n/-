using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BridgeMove : MonoBehaviour {

   

	// Use this for initialization
	void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {

        

        if (transform.rotation.y < 256)
        {
            transform.Rotate(0, 10.0f * Time.deltaTime, 0);
        }
        else if (transform.rotation.y > 183)
        {
            transform.Rotate(0, -10.0f * Time.deltaTime, 0);
        }
	}
}
