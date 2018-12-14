using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class killbox : MonoBehaviour {

    private bool steak = false;
    private bool salad = false;
    private bool onion = false;
    private bool cheese = false;
    private bool bread = false;

    private GameObject pot;
    private GameObject burger;

	// Use this for initialization
	void Start () {
        pot = GameObject.Find("marm");
        burger = GameObject.Find("myBurger");
        burger.SetActive(false);

    }
	    
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name == "Steak_Cooked")
        {
            steak = true;
        }
        if (other.gameObject.name == "Salad")
        {
            salad = true;
        }
        if (other.gameObject.name == "Onion")
        {
            onion = true;
        }
        if (other.gameObject.name == "Cheese_02")
        {
            cheese = true;
        }
        if (other.gameObject.name == "Bread")
        {
            bread = true;
        }
        if (other.gameObject.tag == "food"){
            Destroy(other.gameObject);
        }
        if(steak && salad && onion && cheese && bread)
        {
            pot.SetActive(false);
            burger.SetActive(true);
        }

    }
}
