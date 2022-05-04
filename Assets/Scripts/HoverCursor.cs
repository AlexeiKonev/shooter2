using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


// we put the script on the enemy to change the color of the sight when pointing

public class HoverCursor : MonoBehaviour
{
    

    private void OnMouseEnter()
    {
        //when we take in target enemy scope color change to yellow
        LookCamera.ChangeColorYelow();
    }

    private void OnMouseExit()
    {
        //when we lost   target   scope color change to red
        LookCamera.ChangeColorRed();
    }
}
