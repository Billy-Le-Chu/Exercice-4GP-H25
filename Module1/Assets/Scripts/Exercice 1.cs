using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Exercice1 : MonoBehaviour
{
    private bool _grandirActif;
    private Vector3 _vecteur = new Vector3(0.01f, 0.01f, 0.01f);
    // Start is called before the first frame update
    void Start()
    {
        _grandirActif = true;
        transform.localScale = new Vector3(3, 3, 3);
    }

    // Update is called once per frame
    void Update()
    {
        if (_grandirActif)
        {
            transform.localScale += _vecteur;
        } 
        else
        {
            transform.localScale -= _vecteur;
        }

        if (transform.localScale.magnitude >= 10.0f)
        {
            _grandirActif = false;
        }

        if (transform.localScale.magnitude <= 1.0f)
        {
            _grandirActif = true; 
        }
    }
}
