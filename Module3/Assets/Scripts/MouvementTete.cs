using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouvementTete : MonoBehaviour
{
    [SerializeField] private float vitesse = 1;
    private Vector3 direction = Vector3.right;

    private bool avant = true;

    void Update()
    {
        if (avant)
        {
            transform.localPosition += direction * (vitesse * Time.deltaTime);
        }
        else
        {
            transform.localPosition -= direction * (vitesse * Time.deltaTime);
        }

        if (transform.localPosition.x < -0.2f) avant = true;
        if (transform.localPosition.x > +0.2f) avant = false;
    }
}
