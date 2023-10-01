using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float _jump;
    [SerializeField] private float _force;
    [SerializeField] private Rigidbody _rb;
    private PlayerControls _input;

    private void Awake()
    {
        _input = new PlayerControls();
        _input.ActionMap.Jump.performed += context => Jump();
    }
    private void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }
    private void FixedUpdate()
    {
        JumpForceContol();
    }
    private void Jump()
    {
        _rb.useGravity = true;
        _rb.velocity = Vector3.zero;    
        _rb.AddForce(transform.up * _jump, ForceMode.Impulse);
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
}
