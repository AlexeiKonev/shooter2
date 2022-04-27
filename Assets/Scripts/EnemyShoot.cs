using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoot : MonoBehaviour
{
    [SerializeField]
    private GameObject _bulletEnemy;
    [SerializeField]
    Transform _enemyGun;
    [SerializeField]
    float waitTimeShoot=3f;
    private void Awake()
    {
        _enemyGun = GetComponentInChildren<Transform>();
         
        StartCoroutine("Shooting");
    }

   
    IEnumerator Shooting()
    {
        Instantiate(_bulletEnemy,_enemyGun );
        yield return new WaitForSeconds(waitTimeShoot);
        StartCoroutine("Shooting");
    }
}
