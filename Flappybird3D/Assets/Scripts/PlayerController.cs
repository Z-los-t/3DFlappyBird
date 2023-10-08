using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header("Controls")]
    [SerializeField] private float _jump;
    [SerializeField] private float _speed;
    [SerializeField] private float _rotationSpeed;
    [SerializeField] private float _jumpSpeed;
    [SerializeField] private GameObject _camera;
    [SerializeField] private Rigidbody _rb;
    [Header("PlayerInput")]
    private PlayerInputControls _input;
    [Header("SpawnerScript")]
    [SerializeField] private RoadSpawner Roadspawner;
    [Header("Bird")]
    [SerializeField] private GameObject _frightenedeyes;
    [SerializeField] private GameObject _eyes;

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
        PlayerMovement();
        CameraTranslate();
    }
    private void Jump()
    {
        _rb.useGravity = true;
        _rb.velocity = Vector3.zero;    
        _rb.velocity = Vector2.up * _jump;
    }
    private void PlayerMovement()
    {
        transform.position += new Vector3(_speed * Time.fixedDeltaTime, 0, 0);
        rotation = _rb.velocity.y * _rotationSpeed;
        rotation = Mathf.Clamp(rotation, -90, 50);
        transform.rotation = Quaternion.Euler(0, 0, rotation);
    }
    private void JumpForceContol()
    {
        if(_rb.velocity.y > _jumpSpeed)
        {
            _rb.velocity = new Vector3(0, _jumpSpeed, 0);
        }
    }
    private void CameraTranslate()
    {
        _camera.transform.position += new Vector3(_speed * Time.fixedDeltaTime, 0, 0);
        //_camera.transform.Rotate(0, 0, 0);
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
    private void OnCollisionEnter(Collision collision)
    {
        _frightenedeyes.SetActive(true);
        _eyes.SetActive(false);
        Time.timeScale = 0;
    }
}
