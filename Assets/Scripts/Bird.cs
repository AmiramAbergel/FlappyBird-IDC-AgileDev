using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    public float upForce = 200f;
    private Rigidbody2D birdrigidbody2D;
    private Animator anim;

    private bool isDead = false;
    private void Start(){
        birdrigidbody2D = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }
    private void Update()
    {
        if(isDead == false){
            if (Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Space)){
                anim.SetTrigger("Flap");
                Jump();
            }
        }
    }
    private void Jump(){
        birdrigidbody2D.velocity = Vector2.zero;
        birdrigidbody2D.AddForce(new Vector2 (0,upForce));
    }

    private void OnCollisionEnter2D(){
        birdrigidbody2D.velocity = Vector2.zero;
        isDead = true;
        anim.SetTrigger ("Die");
        GameManager.instance.BirdDied();
    }
}


