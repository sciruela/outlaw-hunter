using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RightButton : MonoBehaviour
{
    public GameObject backgroundGameLoop;
    private bool bButtonPressed;
    public void doMoveRight()
    {
        if ( 10 <= (backgroundGameLoop.GetComponent<Transform>().position[0] - 10)) {
            backgroundGameLoop.GetComponent<Transform>().position = new Vector2(backgroundGameLoop.GetComponent<Transform>().position[0] - 10, backgroundGameLoop.GetComponent<Transform>().position[1]);
        }
        else
        {
            backgroundGameLoop.GetComponent<Transform>().position = new Vector2(10, backgroundGameLoop.GetComponent<Transform>().position[1]);
        }
    }
    public void Update()
    {
        if (bButtonPressed == true)
        {
            doMoveRight();
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
