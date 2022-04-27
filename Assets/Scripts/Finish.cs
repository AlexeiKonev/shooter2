using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish : MonoBehaviour
{
    //ссылка на текст о победе  
   public GameObject winText;
    //ссылка на зону смерти где реализован перезапуск уровня
   private DeathZone deathZoneLink;
    private void Awake()
    {

        winText.SetActive(false);
        deathZoneLink = FindObjectOfType<DeathZone>();
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player") 
        {
            //выводим текст "выйграл"
            winText.SetActive(true);
            //ждем 3 секунды и перезапускаем уровень
            Invoke("Win", 3f);
        } 
    }

    void Win() 
    {
        //вызываем перезапуск уровня 
        deathZoneLink.GameOver();
        Debug.Log("победа");
    }
}
