using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadSpawner : MonoBehaviour
{
    [SerializeField] private float _roadLength;

    [SerializeField] private List<GameObject> _roads;

    private GameObject _road;

    private void Start()
    {
        _road = Instantiate(_roads[Random.Range(0, _roads.Count - 1)], transform.position, Quaternion.identity);
    }

    public void Spawner()
    {
        Vector3 position = new Vector3(_road.transform.position.x + _roadLength, 0, 0);
        _road = Instantiate(_roads[Random.Range(0, _roads.Count - 1)], position, Quaternion.identity);
    }
}
