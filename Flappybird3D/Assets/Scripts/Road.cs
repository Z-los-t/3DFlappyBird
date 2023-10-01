using UnityEngine;

public class Road : MonoBehaviour
{
    [SerializeField] private float _speed;
    private void Start()
    {
        Destroy(gameObject, 5);
    }
    private void FixedUpdate()
    {
        Move();
    }
    private void Move()
    {
        transform.Translate(-transform.right * _speed * Time.fixedDeltaTime);
    }
  
}
