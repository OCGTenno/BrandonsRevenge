using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCollide : MonoBehaviour {

    public int letters = Collectingletters.collectedLetters;
    Scene scene;

    // Use this for initialization
    void Start () {
        scene = SceneManager.GetActiveScene();
    }
	
	// Update is called once per frame
	void Update () {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Hit");

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
                Debug.Log("Working");
            }
        }
    }
}
