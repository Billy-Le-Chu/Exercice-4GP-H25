using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBall : MonoBehaviour
{
    [SerializeField] private float speed = 2f;
    private Rigidbody _rb;
    private Vector3 positionDepart;

    void Start()
    {
        _rb = GetComponent<Rigidbody>();
        positionDepart = transform.position;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            _rb.AddForce(speed * new Vector3(0, 0, -1), ForceMode.Impulse);
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            _rb.AddForce(speed * new Vector3(0, 0, +1), ForceMode.Impulse);
        }

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            _rb.AddForce(speed * new Vector3(-1, 0, 0), ForceMode.Impulse);
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            _rb.AddForce(speed * new Vector3(+1, 0, 0), ForceMode.Impulse);
        }

        _rb.velocity = Vector3.ClampMagnitude(_rb.velocity, speed * 2);
    }
}
