using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControll : MonoBehaviour
{
    //ссылки на компоненты
    private Rigidbody _characterControll;


    public float moveSpeed = 5f;
    
  
    //ссылки для оружия игрока и пуль
    [SerializeField] private GameObject _bullet;
    [SerializeField] private GameObject _gun;

    

    private void Awake()
    {
       
        _characterControll = GetComponent<Rigidbody>();
    }
    void Start()
    {
         Debug.Log("старт игры");
    }

     
    private void FixedUpdate()
    {
        //we track the WASD click and the mouse click for the shot
        Controller();
        // by clicking on the left mouse button shot
        if (Input.GetMouseButtonDown(0))
        {
            BulletSpawn();
        }
    }
     
     
    void BulletSpawn()
    {
        Debug.Log("выстрел");
        Instantiate(_bullet, _gun.transform );
    }
     
   

 private  void Controller()
    { 
        
        //при нажатии W пойдет вперед
        if (Input.GetAxis("Vertical") > 0) { 
            _characterControll.velocity= transform.TransformDirection(Vector3.forward * moveSpeed);
        }

        //при нажатии S пойдет назад
        if (Input.GetAxis("Vertical") < 0) {
            _characterControll.velocity = transform.TransformDirection(Vector3.back * moveSpeed);
        }

        //при нажатии D пойдет вправо
        if (Input.GetAxis("Horizontal") > 0) {
            _characterControll.velocity = transform.TransformDirection(Vector3.right * moveSpeed);
        }


        //при нажатии A пойдет влево
        if (Input.GetAxis("Horizontal") < 0) {
            _characterControll.velocity = transform.TransformDirection(Vector3.left * moveSpeed);
        }
    }
}
