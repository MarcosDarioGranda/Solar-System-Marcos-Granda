using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orbita : MonoBehaviour
{
    public float velocidadOrbita = 40f;
    public Transform puntoPivotar;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.RotateAround(puntoPivotar.transform.position, Vector3.up, velocidadOrbita*Time.deltaTime);
    }
}
