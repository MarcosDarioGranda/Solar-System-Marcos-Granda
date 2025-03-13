using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotacion1 : MonoBehaviour
{
    public float velocidadRotacion = 20f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Rotate(new Vector3(8, velocidadRotacion, 8)*Time.deltaTime);
    }
}
