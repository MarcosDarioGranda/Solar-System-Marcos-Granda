using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotacion3 : MonoBehaviour
{
    public float velocidadRotacion = 10f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Rotate(new Vector3(8, velocidadRotacion, 8) * Time.deltaTime);
    }
}
