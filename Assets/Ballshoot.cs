using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ballshoot : MonoBehaviour
{
    public GameObject ball;
    public Transform box;
    public float force;


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))

        {
            GameObject Ball = Instantiate(ball, box.position, Quaternion.identity);
            Rigidbody2D rb2D = Ball.GetComponent<Rigidbody2D>();
            rb2D.velocity = (Vector2.left * force);
            Destroy(Ball, 3f);

        }

    }

}


