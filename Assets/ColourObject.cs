using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColourObject : MonoBehaviour
{


    public Color color;

    // Start is called before the first frame update
    void Start()
    {
        Renderer myRenderer = GetComponent<Renderer>();

        myRenderer.material.color = color;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
