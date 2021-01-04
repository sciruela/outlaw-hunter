using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftButton : MonoBehaviour
{
    public GameObject backgroundGameLoop;
    private bool bButtonPressed;
    public void doMoveLeft()
    {
        if (1110 >= (backgroundGameLoop.GetComponent<Transform>().position[0] + 10))
        {
            backgroundGameLoop.GetComponent<Transform>().position = new Vector2(backgroundGameLoop.GetComponent<Transform>().position[0] + 10, backgroundGameLoop.GetComponent<Transform>().position[1]);
        } else
        {
            backgroundGameLoop.GetComponent<Transform>().position = new Vector2(1121, backgroundGameLoop.GetComponent<Transform>().position[1]);
        }
    }

    public void Update()
    {
        if (bButtonPressed == true){
            doMoveLeft();
        }
    }
    public void doPressButton()
    {
        bButtonPressed = true;
    }
    public void doUnpressButton()
    {
        bButtonPressed = false;
    }
}

