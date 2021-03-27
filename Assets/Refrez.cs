using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Refrez : MonoBehaviour
{
    public bool triggered;
    public GameObject shop, canvas;
    public PlayerMove player;
    private void Start()
    {
        player = FindObjectOfType<PlayerMove>();
    }


    private void Update()
    {
        canvas.SetActive(triggered);
    }
    public void OpenClose()
    {
        shop.SetActive(!shop.active);
        player.enabled = !shop.active;
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
