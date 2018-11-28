using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour {


    // Public Stuff

    public GameObject       player;                 // (Player Controller)
    public bool             followPlayer;           
    public float            followTimeSec = 10;     // Time Setter
    public Transform[]      Path;                   // Path Array
    public float            speed;                  // Enemy Speed

    // Private Stuff

    public float           chaseTimer = 0.0f;      // Countdown Timer
    private int             nextPath;                
    private Transform       playerTransform;        
    private Transform       target;
    private bool            isRunning;

    void Awake ()
    {
        
        playerTransform = player.transform;
        nextPath = 0;
        target = Path[nextPath];
        followTimeSec = followTimeSec * 60;
	}
	
	// Update is called once per frame
	void Update ()
    { 
        CountDown();


        float movement = speed * Time.deltaTime;

        // Follow Path or Player
        if (followPlayer == false)
        {
            transform.position = Vector3.MoveTowards(transform.position, Path[nextPath].position, movement);
            transform.LookAt(Path[nextPath]);
        }
        else
        {
            transform.position = Vector3.MoveTowards(transform.position, player.transform.position, movement);
            transform.LookAt(player.transform.position);
        }

    }

     

    private void OnCollisionEnter(Collision collision)
    {

        // Check if Colision is Path or Player
        if (collision.transform.gameObject.name == Path[nextPath].name)
        {
            Path[nextPath].GetComponent<BoxCollider>().isTrigger = true;
            nextPath++;
            nextPath = nextPath % Path.Length;
            Path[nextPath].GetComponent<BoxCollider>().isTrigger = false;
            speed += 1;
        }
        if (collision.transform.gameObject.name == player.transform.gameObject.name)
        {
            followPlayer = true;
            chaseTimer = followTimeSec;
            speed = 5;
        }
    }


    void CountDown()
    {
        // it's the final countdown duh-duh-duh
        if (chaseTimer <= 0f)
        {
            followPlayer = false;
            speed = 10;
        }
        else
        {
            chaseTimer -= 1;
            
        }
    }

}
