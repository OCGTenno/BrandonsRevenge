using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    
    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }
        DontDestroyOnLoad(gameObject);
    }

    // Use this for initialization
    void Start()
    {

    }

    public void RestartLevel(float delay)
    {
        StartCoroutine(RestartLevelDelay(delay));
    }

    private IEnumerator RestartLevelDelay(float delay)
    {
        yield return new WaitForSeconds(delay);
        SceneManager.LoadScene("CliffBrandon Floor2");
    }

    // Update is called once per frame
    void Update()
    {

    }
}
