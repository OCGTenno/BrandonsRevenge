using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlickeringLights : MonoBehaviour
{

    Light flickerLight;
    public float minWaitTime;
    public float maxWaitTime;

    void Start()
    {

        flickerLight = GetComponent<Light>(); //grabs the light

        StartCoroutine(Flashing()); //grabs the flashing function
    }

    IEnumerator Flashing ()
    {
        while(true)
        {
            
            yield return new WaitForSeconds(Random.Range(minWaitTime, maxWaitTime)); //adds a random wait time between the min and max wait times
            flickerLight.enabled = !flickerLight.enabled;
            
        }
    }

}
