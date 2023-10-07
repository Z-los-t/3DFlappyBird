using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudSpawner : MonoBehaviour
{
    [SerializeField] private GameObject _cloud;
    [SerializeField] private float _radious;
    [SerializeField] private float _livetime;
    void Start()
    {
        Debug.Log("spawn0");
        InvokeRepeating("cloudSpawn", 0, 1);
    }
    private void cloudSpawn()
    {
        Debug.Log("spawn1");
        int counts = Random.Range(4, 6);
       for(int i = 0; i < counts; i++)
        {
            Debug.Log("spawn2");
            Vector3 randomPoint = Random.insideUnitCircle * _radious;
            GameObject Cloud = Instantiate(_cloud, randomPoint + transform.position, Quaternion.identity);
        }
    }
}
