using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bathit : MonoBehaviour
{
    private bool drag = false;
    public Rigidbody2D bat;
    public GameObject ball;

    private void Update()
    {
        if (drag)
        {
            bat.MovePosition(Camera.main.ScreenToWorldPoint(Input.mousePosition));
        }


        if (Input.GetMouseButtonDown(0))
        {
            drag = true;

        }
        if (Input.GetMouseButtonUp(0))
        {
            drag = false;
        }
    }

}
