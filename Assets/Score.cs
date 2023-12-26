using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public GameObject ball;
    public int Scoreval = 0;
    public Text score;


    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Bat"))
        {
            Scoreval += 1;
            score.text = "Score:" + Scoreval;
        }


        if (collision.gameObject.CompareTag("Two"))
        {
            Scoreval += 2;
            score.text = "Score:" + Scoreval;

        }
        if (collision.gameObject.CompareTag("Four"))
        {
            Scoreval += 4;
            score.text = "Score:" + Scoreval;


        }
        if (collision.gameObject.CompareTag("Six"))
        {
            Scoreval += 6;
            score.text = "Score:" + Scoreval;


        }

    }
}
