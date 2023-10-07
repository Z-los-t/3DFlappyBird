using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header("Controls")]
    [SerializeField] private float _jump;
    [SerializeField] private float _rotationSpeed;
    [SerializeField] private float _force;
    [SerializeField] private Rigidbody _rb;
    [Header("PlayerInput")]
    private PlayerInputControls _input;
    [Header("SpawnerScript")]
    [SerializeField] private RoadSpawner Roadspawner;

    float rotation;
    private void Awake()
    {
        _input = new PlayerInputControls();
        _input.ActionMap.Jump.performed += context => Jump();
    }
    private void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }
    private void FixedUpdate()
    {
        JumpForceContol();
        rotation = _rb.velocity.y * _rotationSpeed;
        rotation = Mathf.Clamp(rotation, -90, 50);
        transform.rotation = Quaternion.Euler(0, 0, rotation);   
    }
    private void Jump()
    {
        _rb.useGravity = true;
        _rb.velocity = Vector3.zero;    
        _rb.velocity = Vector2.up * _jump;
    }
    private void JumpForceContol()
    {
        if(_rb.velocity.y > _force)
        {
            _rb.velocity = new Vector3(0, _force, 0);
        }
    }
    private void OnEnable()
    {
        _input.Enable();
    }
    private void OnDisable()
    {
        _input.Disable();
    }
    private void OnTriggerExit(Collider other)
    {
        Roadspawner.Spawner();
    }
}
