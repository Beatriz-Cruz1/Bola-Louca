using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camara : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject jogador;
    private Vector3 diferenca; 
    void Start()
    {
        diferenca = transform.position - jogador.transform.position;

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = jogador.transform.position + diferenca;

    }
}
