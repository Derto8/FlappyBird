using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public GameObject Pipes;        // ���������� ��� �������� 

    void Start()
    {
        StartCoroutine(Spawner());  // �������� �������� "Spawner" 
    }

    IEnumerator Spawner()           // ��������
    {
        while (true)                // ����������� ���� While
        {
            yield return new WaitForSeconds(3);     // ���� 2 �������
            float rand = Random.Range(-1.4f, -5.2f);     // ��������� ������� �� -1 �� 4 (���� ������� ����)
            GameObject newPipes = Instantiate(Pipes, new Vector3(2, rand, 0), Quaternion.identity);     // ��������� �������������� �� ����� gameObject � ������� ������
            Destroy(newPipes, 10);  // �������� ������ gameObject'a ����� 10 ������
        }
    }
}
