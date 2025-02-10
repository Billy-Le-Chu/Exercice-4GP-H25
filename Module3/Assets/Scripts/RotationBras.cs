using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationBras : MonoBehaviour
{
    [SerializeField] private float vitesseRotation = 180;

    void Update()
    {
        transform.Rotate(new Vector3(0, 0, 1), Time.deltaTime * vitesseRotation);
    }
}
