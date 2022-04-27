using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathZone : MonoBehaviour
{
 public   GameObject gameover;
    private void Awake()
    {
        gameover.SetActive(false);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player") 
        {
            gameover.SetActive(true);
            Debug.Log("фейл");
            Invoke("GameOver",1.5f);
        }
    }
  //  функция презапуска уровня
  public  void GameOver() 
    {
        SceneManager.LoadScene(0);
    }
}
