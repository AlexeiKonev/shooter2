using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LookCamera : MonoBehaviour
{
    public float sensityvyHorizont = 9f;

    //картинка прицела
    
    public static Image _cursor;
        
    void Start()
    {
        _cursor = GameObject.Find("Scope").GetComponent<Image>();
        ChangeColorYelow();
        //fix cursor to centr of screen
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

     
    void Update()
    {
        transform.Rotate(0, Input.GetAxis("Mouse X") * sensityvyHorizont, 0);
    }

    public static void ChangeColorYelow() 
    {

        //yellow (255,255,0)
        _cursor.color = new Color(255, 255, 0);
    } 
    public static void ChangeColorRed() 
    {

        //red (255,0,0) 
        _cursor.color = new Color(255, 0, 0);
    }
}
