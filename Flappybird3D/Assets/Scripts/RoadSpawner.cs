using System.Collections.Generic;
using UnityEngine;

public class RoadSpawner : MonoBehaviour
{
    [SerializeField] private List<GameObject> _roads;
    [SerializeField] private GameObject _pipe;
    private Vector3 _position;
    private void Start()
    {
        for(int i = 0; i < 10; i++)
        {
            GameObject _road = Instantiate(_roads[Random.Range(0, _roads.Count)], transform.position, Quaternion.Euler(0, 0, 0));
            _position.x += _road.transform.position.x/2;
            _road.transform.Translate(_position);
        }
    }
    public void Spawn()
    {
        GameObject _road = Instantiate(_roads[Random.Range(0, _roads.Count)], transform.position, Quaternion.Euler(0, 0, 0));
        _position.x += _road.transform.position.x / 2;
        _road.transform.Translate(_position);
    }
}
