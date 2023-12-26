using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Stunphit : MonoBehaviour
{
    public GameObject ball;
    public Canvas Pg4_gameover;
    public Text HighScore;
    public Score sc;


    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("ball"))
        {
            Pg4_gameover.enabled = true;


        }
    }
    private void Start()
    {
        HighScore.text = "Highscore: " + sc.Scoreval;
    }



}
