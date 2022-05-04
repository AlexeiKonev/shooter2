using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAgent : MonoBehaviour
{
    //effect activate when enemy shoted
    [SerializeField] private GameObject effect;
    //patrol points
    [SerializeField] private Transform _point1;
    [SerializeField] private Transform _point2;
    //patrol delay  time 
    [SerializeField] private float _waitTime = 2f; 
    
    [SerializeField] private float _moveSpeed = 4f;
    private bool CanGo = true;


    void Start()
    {
         
    }

     
    void Update()
    {
        if (CanGo)
            transform.position = Vector3.MoveTowards(transform.position, _point1.position, _moveSpeed * Time.deltaTime);
        if (transform.position == _point1.position)
        {
            Transform t = _point1;
            _point1 = _point2;
            _point2 = t;
            CanGo = false;
            StartCoroutine(Wait());
        }

        IEnumerator Wait()
        {
            yield return new WaitForSeconds(_waitTime);

            CanGo = true;
        }
        




    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "bullet") 
        {
            effect.SetActive(true);
            Invoke("DestroyEnemy", 1f);
        }
    }

    private void  DestroyEnemy()
    {
        Debug.Log("попадание в агента");
        Destroy(this.gameObject);
        
    }
}   
