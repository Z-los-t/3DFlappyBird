using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudSpawner : MonoBehaviour
{
    [SerializeField] private GameObject _cloud;
    [SerializeField] private float _radious;
    [SerializeField] private int _livetime;
    [SerializeField] private int _interval;
    void Start()
    {
        Debug.Log("spawn0");
        InvokeRepeating("cloudSpawn", 0, _interval);
    }
    private void cloudSpawn()
    {
        Debug.Log("spawn1");
        int counts = Random.Range(3, 5);
       for(int i = 0; i < counts; i++)
        {
            Debug.Log("spawn2");
            Vector3 randomPoint = Random.insideUnitSphere * _radious;
            GameObject Cloud = Instantiate(_cloud, randomPoint + transform.position, Quaternion.identity);
            //float RandomHeight = Random.RandomRange(3, 4);
            //float RandomWith = Random.RandomRange(1, 3);
           //Cloud.transform.localScale = new Vector3(RandomHeight/RandomWith, RandomWith, RandomWith);
        }
    }
}
