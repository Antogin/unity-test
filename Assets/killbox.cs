using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class killbox : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	    
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject.tag);
        if(other.gameObject.tag == "food"){
            Destroy(other.gameObject);
        }
    }
}
