using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercice6 : MonoBehaviour
{
    [SerializeField] private GameObject joueur;
    [SerializeField] private float hauteur;
   // Start is called before the first frame update
   void Start()
    {
        PlacerCamera();
    }

    // Update is called once per frame
    void LateUpdate()
    {
        PlacerCamera();
    }

    private void PlacerCamera()
    {
        float x = joueur.transform.position.x;
        float z = joueur.transform.position.z;  
        transform.position = new Vector3(x, hauteur, z);
    }
}
