using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    
    [SerializeField] 
    Rigidbody _rigidbodyBullet;
    //���� ��������
    [SerializeField]
    float _shootforce = 170f;
    //����� ����� ���� � ��������
    [SerializeField]
    float _bulletLifeTime=4f;
     
    private void Awake()
    {
         
         
        _rigidbodyBullet = GetComponent<Rigidbody>();
        this.Shoot();
    }

    public void Shoot()
    {
        _rigidbodyBullet.velocity = transform.TransformDirection(Vector3.forward * _shootforce);
        Invoke("DeleteBullet", _bulletLifeTime);
         



    }
    void DeleteBullet()
    {
       
        Destroy(this.gameObject);
    }
}
