using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Base : MonoBehaviour
{
    public Canvas Pg1_home;
    public GameObject Pg2_game;
    public Canvas Pg3_score;
    public Canvas Pg4_gameover;

    void Start()
    {
        Pg1_home.enabled = true;
        Pg2_game.SetActive(false);
        Pg3_score.enabled = false;
        Pg4_gameover.enabled = false;

    }
    public void Page1_Canvas()
    {
        Pg1_home.enabled = true;
        Pg2_game.SetActive(false);
        Pg3_score.enabled = false;
        Pg4_gameover.enabled = false;
    }
    public void Page2_Canvas()
    {
        Pg1_home.enabled = false;
        Pg2_game.SetActive(true);
        Pg3_score.enabled = true;
        Pg4_gameover.enabled = false;
    }


}
