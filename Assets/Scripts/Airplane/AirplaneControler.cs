
using UnityEngine;

public class AirplaneControler : MonoBehaviour
{
    [SerializeField] private Rigidbody _rigidbody;
    [SerializeField] private float _speed = 0.1f;
    [SerializeField] private float _torqueSpeed;

    private float horizontalInput;
    private float verticalInput;

    private void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        _rigidbody.velocity = transform.forward * _speed * Time.deltaTime;
        

    }


    private void FixedUpdate()
    {
        _rigidbody.AddTorque((transform.forward * _torqueSpeed * Time.deltaTime * -horizontalInput));
        _rigidbody.AddTorque((transform.right * _torqueSpeed * Time.deltaTime * -verticalInput));
    }
}
