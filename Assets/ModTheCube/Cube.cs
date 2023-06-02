using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public MeshRenderer Renderer;
    private Material material;
    
    void Start()
    {
        transform.position = new Vector3(3, 4, 1);
        transform.localScale = Vector3.one * Random.RandomRange(2.0f, 4.0f); //alerado o tamanho
        
        material = Renderer.material;
         
    }
    
    void Update()
    {
        transform.Rotate(10.0f * Time.deltaTime, 0.0f, 0.0f);
        float r = Random.RandomRange(0.0f, 1.0f);
        float g = Random.RandomRange(0.0f, 1.0f);
        float b = Random.RandomRange(0.0f, 1.0f);
        float a = Random.RandomRange(0.0f, 1.0f);

        material.color = new Color(r, g, b, a);// alterado a cor
    }
}
