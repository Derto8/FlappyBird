using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public GameObject Pipes;        // переменная для префабов 

    void Start()
    {
        StartCoroutine(Spawner());  // включаем корутину "Spawner" 
    }

    IEnumerator Spawner()           // корутина
    {
        while (true)                // бесконечный цикл While
        {
            yield return new WaitForSeconds(3);     // ждем 2 секунды
            float rand = Random.Range(-1.4f, -5.2f);     // рандомная позиция от -1 до 4 (чтоб удобнее было)
            GameObject newPipes = Instantiate(Pipes, new Vector3(2, rand, 0), Quaternion.identity);     // переносим отвественность на новый gameObject и создаем префаб
            Destroy(newPipes, 10);  // удаление нового gameObject'a через 10 секунд
        }
    }
}
