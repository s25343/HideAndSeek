using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundBumb : MonoBehaviour
{
    public AudioSource bumb;
    public AudioClip bumbSound;

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Walls")
        {
            print("bumb");
            bumb.PlayOneShot(bumbSound);
        }
    }
}
