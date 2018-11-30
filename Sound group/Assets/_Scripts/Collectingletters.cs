using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectingletters : MonoBehaviour
{
    public GameObject[]letters = new GameObject[7];
    public int collectedLetters;
    public GameObject Player;
    public AudioClip collectSound;
    
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
	    	
	}

    private void OnTriggerEnter(Collider collider)
    {

        for (int i = 0; i < letters.Length; i++)
        {


            if (collider.transform.gameObject.name == letters[i].name)
            {
                collectedLetters++;
                collider.gameObject.SetActive(false);
                AudioSource.PlayClipAtPoint(collectSound, transform.position); 

            }
        }
    }
}