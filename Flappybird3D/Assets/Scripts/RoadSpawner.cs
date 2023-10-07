using System.Collections.Generic;
using UnityEngine;

public class RoadSpawner : MonoBehaviour
{
    [SerializeField] private List<GameObject> _roads;
    [SerializeField] private GameObject _pipe;
    private void Start()
    {
       //InvokeRepeating("PipeSpawner", 2, 1);
    }
    public void Spawner()
    {
        GameObject _road = Instantiate(_roads[Random.Range(0, _roads.Count)], transform.position, Quaternion.identity);
    }
    private void PipeSpawner()
    {
        Vector3 height = new Vector3(transform.position.x, Random.Range(3, 13), transform.position.z);
        Instantiate(_pipe, height, Quaternion.identity);
    }
}
