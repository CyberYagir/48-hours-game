using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stol : MonoBehaviour
{

    public bool triggered;
    public GameObject canvas;
    public List<AudioClip> clips;
    public AudioSource source;
    private void Start()
    {
    }
    public void SayMat()
    {
        if (source.isPlaying == false)
        {
            source.PlayOneShot(clips[Random.Range(0, clips.Count)]);
            FindObjectOfType<Stats>().hp -= Random.Range(2, 6);
            FindObjectOfType<Stats>().zlch -= Random.Range(30, 50);
            FindObjectOfType<Stats>().patriot += Random.Range(20, 30);
        }
    }

    private void Update()
    {
        canvas.SetActive(triggered);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        triggered = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        triggered = false;
    }
}
