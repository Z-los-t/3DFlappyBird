using System.Collections.Generic;
using UnityEngine;

public class RoadSpawner : MonoBehaviour
{
    [SerializeField] private List<GameObject> _roads;
    public void Spawner()
    {
        GameObject _road = Instantiate(_roads[Random.Range(0, _roads.Count)], transform.position, Quaternion.identity);
    }
}
