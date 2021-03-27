using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Divan : MonoBehaviour
{
    public GameObject canvas;
    public GameObject sitButton, upButton;
    public bool triggered;
    public Sprite sprite1, sprite2;
    public GameObject player;
    public Stats stats;
    public bool on;
    private void Start()
    {
        stats = FindObjectOfType<Stats>();
        player = FindObjectOfType<PlayerMove>().gameObject;

    }
    private void Update()
    {
        canvas.SetActive(triggered || on);
        if (triggered || on)
        {
            sitButton.SetActive(!on);
            upButton.SetActive(on);
        }
        if (on)
        {
            if (stats.dead >= 100)
            {
                Up();
            }
            stats.patriot += Mathf.Abs(stats.patriotsub * 10);
            stats.zlch += Mathf.Abs(stats.patriotsub * 5);
        }
    }

    public void Sit()
    {
        GetComponent<SpriteRenderer>().sprite = sprite2;
        player.gameObject.SetActive(false);
        Time.timeScale = 2;
        
        on = true;
    }
    public void Up()
    {
        GetComponent<SpriteRenderer>().sprite = sprite1;
        player.gameObject.SetActive(true);
        Time.timeScale = 1;
        on = false;
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
