using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Hidder : MonoBehaviour
{
    public AudioSource win;
    public AudioClip winSound;
    // Start is called before the first frame update
    void Start()
    {
        //gameObject.transform.Translate(6, 0, 3);
        //win = GetComponent<AudioSource>();
    }

    void Update() { }

    private void OnCollisionEnter(Collision collision)
    {
        Vector3 pos1 = new Vector3(-13, 0.45f, -12);
        Vector3 pos2 = new Vector3(-4, 0.45f, 7);
        Vector3 pos3 = new Vector3(0.2f, 2.5f, -7);
        Vector3 pos4 = new Vector3(-2, 0.45f, 3);
        List<Vector3> positions = new List<Vector3>() { pos1, pos2, pos3, pos4 };

        System.Random rand = new System.Random();
        int someRandomNumber = rand.Next(0, positions.Count());
        print("Pos count : "+positions.Count());

        if (collision.gameObject.tag == "Seeker")
        {
            print("win");
            win.PlayOneShot(winSound);
            gameObject.transform.position = positions[someRandomNumber];
            print("Random Pos: " + positions + " ||||||| " +positions[someRandomNumber]);
        }
    }
}