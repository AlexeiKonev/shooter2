using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


// ставим скрипт на врага чтобы при наведении менять цвет прицела

public class HoverCursor : MonoBehaviour
{
    

    private void OnMouseEnter()
    {
        LookCamera.ChangeColorRed();
    }

    private void OnMouseExit()
    {
        LookCamera.ChangeColorYelow();
    }
}
