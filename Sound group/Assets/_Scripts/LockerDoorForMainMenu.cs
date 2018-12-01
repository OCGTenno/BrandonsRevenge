using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockerDoorForMainMenu : MonoBehaviour
{
    private Animator _animatorMainMenu;

    //for the times between when it opens
    public float minTime;
    public float maxTime;

    // Use this for initialization
    void Start()
    {
        _animatorMainMenu = GetComponent<Animator>();

        StartCoroutine(CallIt());
    }

   //private void AgainCall()
   // {

   // }

    private void lockerOpen()
    {
        _animatorMainMenu.SetBool("Open", true);
    }

    private void lockerClose()
    {
        _animatorMainMenu.SetBool("Open", false);
    }

    IEnumerator OpenClose ()
    {
        lockerOpen();
        yield return new WaitForSeconds(4);
        lockerClose();
    }

    IEnumerator CallIt ()
    {
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(minTime, maxTime));
            StartCoroutine(OpenClose());
        }
    }

    void Update()
    {

    }
}
