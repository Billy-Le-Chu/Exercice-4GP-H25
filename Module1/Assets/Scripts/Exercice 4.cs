using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercice4 : MonoBehaviour
{
    [SerializeField] float _force;

    private Rigidbody _rbody;
    private float _horizontal;
    private float _vertical;

    private Vector3 _position;

    // Start is called before the first frame update
    void Start()
    {
        _vertical = 0.0f;
        _horizontal = 0.0f;
        _rbody = GetComponent<Rigidbody>();
        _position = transform.position;
    }

    void Update()
    {
        _horizontal = Input.GetAxis("Horizontal");
        _vertical = Input.GetAxis("Vertical");
    }


    private void FixedUpdate()
    {
        Vector3 force = new Vector3(_horizontal, 0, _vertical);
        force *= _force;
        _rbody.AddForce(force);
    }

    public void ReplacerJoueur()
    {
        transform.position = _position;
        _rbody.velocity = Vector3.zero;
        _rbody.angularVelocity = Vector3.zero;
    }

}
