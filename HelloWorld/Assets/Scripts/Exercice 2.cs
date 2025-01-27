using UnityEngine;

public class Exercice2 : MonoBehaviour
{
    private bool _grandirActif;
    private Vector3 _vecteur = new Vector3(0.01f, 0.01f, 0.01f);
    [SerializeField] private float _vitesse;
    // Start is called before the first frame update
    void Start()
    {
        _grandirActif = true;
        transform.localScale = new Vector3(3, 3, 3);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 croissance = _vecteur * Time.deltaTime * _vitesse;
        if (_grandirActif)
        {
            transform.localScale += croissance;
        }
        else
        {
            transform.localScale -= croissance;
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
