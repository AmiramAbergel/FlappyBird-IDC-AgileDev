using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingObject : MonoBehaviour
{
    private Rigidbody2D birdrigidbody2D;
    void Start()
    {
        birdrigidbody2D = GetComponent<Rigidbody2D>();
        birdrigidbody2D.velocity = new Vector2 (GameManager.instance.scrollSpeed, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if(GameManager.instance.gameOver == true)
        {
            birdrigidbody2D.velocity = Vector2.zero;
        }
    }
}
