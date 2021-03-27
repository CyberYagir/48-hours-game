using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balkon : MonoBehaviour
{
    public bool played;
    float time;
    public List<AudioClip> clips = new List<AudioClip>();
    public AudioSource audioSource;
    private void Update()
    {
        if (played)
        {
            time += 1 * Time.deltaTime;
            FindObjectOfType<PlayerMove>().enabled = false;
            if (FindObjectOfType<PlayerMove>().animator.GetCurrentAnimatorStateInfo(0).IsTag("Mat"))
            {
                FindObjectOfType<Stats>().zlch -= 40 * Time.deltaTime;
            }
            else
            {
                if (time > 1)
                {
                    FindObjectOfType<PlayerMove>().enabled = true;
                    played = false;
                    time = 0;
                }
            }
        }
    }
    public void Mat()
    {
        if (FindObjectOfType<PlayerMove>().animator.GetCurrentAnimatorStateInfo(0).IsTag("Mat") == false)
        {
            played = true;
            FindObjectOfType<PlayerMove>().enabled = false;
            FindObjectOfType<PlayerMove>().animator.Play("Mat");
            audioSource.Stop();
            audioSource.PlayOneShot(clips[Random.Range(0, clips.Count)]);
        }
    }
}
