using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLocation : MonoBehaviour
{
    public List<Location> locations = new List<Location>();
    public GameObject player;
    public Animator animator;
    public AudioClip openDoor, goniDengi;

    public void Go(bool left, int loc)
    {
        for (int i = 0; i < locations.Count; i++)
        {
            locations[i].locObject.SetActive(loc == i);
        }
        GetComponent<AudioSource>().Stop();
        animator.Play("ToLocationAnim");
        GetComponent<AudioSource>().PlayOneShot(openDoor);
        print("Anim");
        if (left) player.transform.position = locations[loc].p1.transform.position; else player.transform.position = locations[loc].p2.transform.position;
        FindObjectOfType<TV>()?.rnd();
    }
    public void ToHome()
    {


        FindObjectOfType<Podiezd>().gazeta.SetActive(false);
        Go(true, 2);
        int p = Random.Range(1, 6);
        print(p);
        if (p == 1)
        {
            GetComponent<AudioSource>().Stop();
            GetComponent<AudioSource>().PlayOneShot(goniDengi);
            FindObjectOfType<Stats>().money = 0;
        }
    }

}

[System.Serializable]
public class Location {
    public Transform p1, p2;

    public GameObject locObject;

}

