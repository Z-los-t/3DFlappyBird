
using UnityEngine;

public class Road : MonoBehaviour
{
    [SerializeField] private float _speed;



    private void FixedUpdate()
    {
        Move();
    }
    private void Move()
    {
        transform.Translate(-transform.right * _speed * Time.fixedDeltaTime);
    }
  
}
