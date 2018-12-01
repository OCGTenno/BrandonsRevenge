using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

	// Use this for initialization
	public void StartGame () {
        SceneManager.LoadScene("CliffBrandon Floor2");
	}

    public void Quit()
    {
        Application.Quit();
    }

    // Update is called once per frame
    void Update () {
		
	}
}
