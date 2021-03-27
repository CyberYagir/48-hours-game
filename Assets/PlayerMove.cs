using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float speed;
    public Rigidbody2D rb;
    public GameObject torso;
    public Animator animator;
    private void Update()
    {
        if (Input.GetAxisRaw("Horizontal") < 0)
        {
            animator.Play("Move");
            torso.transform.localScale = new Vector3(-Mathf.Abs(torso.transform.localScale.x), torso.transform.localScale.y, torso.transform.localScale.z);
            rb.AddForce(Vector2.left * speed * Time.deltaTime);
        }else
        if (Input.GetAxisRaw("Horizontal") > 0)
        {
            animator.Play("Move");
            torso.transform.localScale = new Vector3(Mathf.Abs(torso.transform.localScale.x), torso.transform.localScale.y, torso.transform.localScale.z);
            rb.AddForce(Vector2.right * speed * Time.deltaTime);
        }
        else
        {
            animator.Play("Idle");
        }
    }
}
