using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sword : Collidable
{
    private Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {

            animator.SetTrigger("Swinging");
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Destroy(collision.gameObject);
            Health.health += 1;
        }
    }
}
