using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToLocation : MonoBehaviour
{
    public bool left;
    public int location;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        FindObjectOfType<MoveLocation>().Go(left, location);
    }
}
