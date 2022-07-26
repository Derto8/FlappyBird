using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene : MonoBehaviour
{
    public void RestartGame()
    {
        // SceneManager.LoadScene(SceneManager.GetActiveScene().name); // перезагрузка сцены
        //SceneManager.LoadScene(0);
        if (Input.GetMouseButtonDown(0))                // если жмем на кнопку мыши или экран
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

}
