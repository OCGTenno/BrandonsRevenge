using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Letter : Collectingletters
{



	// Use this for initialization
	void Start () {
		
	}

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.tag == "Player")
        {
            
        }
    }

    // Update is called once per frame
    void Update () {
		
	}
}
