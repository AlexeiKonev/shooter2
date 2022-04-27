using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LookCamera : MonoBehaviour
{
    public float sensityvyHorizont = 9f;

    //картинка прицела
    
    public static Image _cursor;
    //red (255,0,0)     yellow (255,255,0)
    void Start()
    {
        _cursor = GameObject.Find("Scope").GetComponent<Image>();
        ChangeColorYelow();
        //фиксируем курсор по центру и делаем невидимым
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, Input.GetAxis("Mouse X") * sensityvyHorizont, 0);
    }

    public static void ChangeColorYelow() 
    {
        
        //желтый
        _cursor.color = new Color(255, 255, 0);
    } 
    public static void ChangeColorRed() 
    {

        //красный
        _cursor.color = new Color(255, 0, 0);
    }
}
