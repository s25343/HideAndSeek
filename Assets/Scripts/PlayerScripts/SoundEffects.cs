using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundEffects : MonoBehaviour
{
    public GameObject footsteps;
    public GameObject jump;
    void Start()
    {
        footsteps.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown("w"))
        {
            footsteps.SetActive(true);
        }
        if (Input.GetKeyDown("a"))
        {
            footsteps.SetActive(true);
        }
        if (Input.GetKeyDown("s"))
        {
            footsteps.SetActive(true);
        }
        if(Input.GetKeyDown("d"))
        {
            footsteps.SetActive(true);
        }

        if (Input.GetKeyUp("w"))
        {
            Stopfootsteps();
        }
        if (Input.GetKeyUp("a"))
        {
            Stopfootsteps();
        }
        if (Input.GetKeyUp("s"))
        {
            Stopfootsteps();
        }
        if (Input.GetKeyUp("d"))
        {
            Stopfootsteps();
        }
        if(Input.GetKeyDown(KeyCode.Space))
        {
            jump.SetActive(true);
        }


        void Stopfootsteps()
        {
            footsteps.SetActive(false);
        }
    }

}
