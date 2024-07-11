using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class MainCharacter : MonoBehaviour
{
    [SerializeField] private float speed = 5f;

    private Rigidbody2D rb;
    private Animator animator;
    private Vector2 moveVector;

    private void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        animator = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + moveVector * speed * Time.deltaTime);
    }

    private void Update(){
        moveVector.x = Input.GetAxisRaw("Horizontal");
        moveVector.y = Input.GetAxisRaw("Vertical");

        if(moveVector.x!=0||moveVector.y!=0)
        {
            animator.SetBool("isMoving", true);
        }
        else
        {
            animator.SetBool("isMoving", false);
        }

        if(moveVector.x==-1)
        {
            transform.rotation = Quaternion.Euler(0,180,0);
        }
        if(moveVector.x==1)
        {
           transform.rotation = Quaternion.Euler(0,0,0);
        }

    }
}
