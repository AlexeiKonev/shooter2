using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAgent : MonoBehaviour
{
    public GameObject effect;
    [SerializeField] private Transform _point1;
    [SerializeField] private Transform _point2;
    [SerializeField] private float _waitTime = 2f;
    private float _speed = 4f;
    private bool CanGo = true;


    void Start()
    {
         
    }

    // Update is called once per frame
    void Update()
    {
        if (CanGo)
            transform.position = Vector3.MoveTowards(transform.position, _point1.position, _speed * Time.deltaTime);
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
