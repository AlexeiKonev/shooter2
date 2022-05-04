using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControll : MonoBehaviour
{
    //������ �� ����������
    private Rigidbody _characterControll;


    public float moveSpeed = 5f;
    
  
    //������ ��� ������ ������ � ����
    [SerializeField] private GameObject _bullet;
    [SerializeField] private GameObject _gun;

    

    private void Awake()
    {
       
        _characterControll = GetComponent<Rigidbody>();
    }
    void Start()
    {
         Debug.Log("����� ����");
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
        Debug.Log("�������");
        Instantiate(_bullet, _gun.transform );
    }
     
   

 private  void Controller()
    { 
        
        //��� ������� W ������ ������
        if (Input.GetAxis("Vertical") > 0) { 
            _characterControll.velocity= transform.TransformDirection(Vector3.forward * moveSpeed);
        }

        //��� ������� S ������ �����
        if (Input.GetAxis("Vertical") < 0) {
            _characterControll.velocity = transform.TransformDirection(Vector3.back * moveSpeed);
        }

        //��� ������� D ������ ������
        if (Input.GetAxis("Horizontal") > 0) {
            _characterControll.velocity = transform.TransformDirection(Vector3.right * moveSpeed);
        }


        //��� ������� A ������ �����
        if (Input.GetAxis("Horizontal") < 0) {
            _characterControll.velocity = transform.TransformDirection(Vector3.left * moveSpeed);
        }
    }
}
