using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Collectingletters : MonoBehaviour
{

    Scene scene;

    public GameObject[]letters = new GameObject[7];
    public int collectedLetters;
    public GameObject Player;
    public AudioClip collectSound;
    
	// Use this for initialization
	void Start () {
        scene = SceneManager.GetActiveScene();
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

            if (scene.name == "CliffBrandon Floor2")
            {
                if (collectedLetters == 3 && collider.transform.gameObject.name == "Trigger")
                {
                    SceneManager.LoadScene("AlexShayne Floor1");
                }
            }

            if (scene.name == "AlexShayne Floor1")
            {
                if (collectedLetters == 3 && collider.transform.gameObject.name == "Trigger")
                {
                    SceneManager.LoadScene("Theater");
                    Debug.Log("Working");
                }
            }
        }
    }
}