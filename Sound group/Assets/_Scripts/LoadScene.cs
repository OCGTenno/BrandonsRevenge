using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour {

    public int letters = Collectingletters.collectedLetters;
    public GameObject boxTrigger;


    Scene scene;
    private string Floor;

    void Start()
    {
        boxTrigger.SetActive(false);   // Set the Trigger to off so they cant skip to the next level

        scene = SceneManager.GetActiveScene();  // Check scene and assign names of the scenes to each floor


    }

    // Use this for initialization
    public void onTriggerEnter () {

        if (scene.name == "CliffBrandon Floor2")
        {
            if (letters == 3)
            {
                SceneManager.LoadScene("AlexShayne Floor1");
            }
        }

        if (scene.name == "AlexShayne Floor1")
        {
            if (letters == 6)
            {
                SceneManager.LoadScene("Theater");
            }
        }

    }
	
	// Update is called once per frame
	void Update () {

        if (scene.name == "CliffBrandon Floor2")
        {
            if (letters == 3)
            {
                boxTrigger.SetActive(true);
            }
        }

        else if (scene.name == "AlexShayne Floor1")
        {
            if (letters == 6)
            {
                boxTrigger.SetActive(true);
            }
        }

        else
        {
            boxTrigger.SetActive(false);
        }

    }
}
