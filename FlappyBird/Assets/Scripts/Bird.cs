using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    public float force;                                 // переменная для силы прыжка
    Rigidbody2D BirdRigid;                              // нам нужен Rigidbody, а то птичка не будет прыгать

    public GameObject RestartButton;                    // игровой объект для кнопки

    void Start()
    {
        Time.timeScale = 1;
        BirdRigid = GetComponent<Rigidbody2D>();        //  получаем компонент Rigidbody
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))                // если жмем на кнопку мыши или экран
        {
            BirdRigid.velocity = Vector2.up * force;    // настройка силы прыжка
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)  // проверяем столкновение
    {
        if (collision.collider.tag == "EndGame")          // если тэг объекта "Enemy"
        {
            Destroy(gameObject);                        // то птичка уничтожаеся
            Time.timeScale = 0;                         //остановка времени
            RestartButton.SetActive(true);              // кнопка рестарта появляется при столкновении
        }
    }
}
