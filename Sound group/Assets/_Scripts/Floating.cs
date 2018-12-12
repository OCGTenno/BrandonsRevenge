using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Floating : MonoBehaviour
{
    public GameObject Player;
    public float stuffPerSec = 15.0f;
    public float amp = 0.5f;
    public float freq = 1f;
    bool Bobbing = true;

    Vector3 possoff = new Vector3();
    Vector3 tempPos = new Vector3();

    // Use this for initialization
    void Start()
    {
        possoff = transform.position;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (Player.tag == "Player")
        {
            Bobbing = false;
        }
    }

    

    private bool BeginFLoating()
    {
        while (Bobbing == true)
        {
            transform.Rotate(new Vector3(0f, Time.deltaTime * stuffPerSec, 0f), Space.World);

            tempPos = possoff;
            tempPos.y += Mathf.Sin(Time.fixedTime * Mathf.PI * freq) * amp;

            transform.position = tempPos;
        }
        return BeginFLoating();
    }
    // Update is called once per frame
    void Update()
    {
        BeginFLoating();
    }
}
