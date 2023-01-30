using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    public Material[] materials;
    Renderer rend;



    private void Start()
    {
        rend = GetComponent<Renderer>();
        rend.enabled= true;
        rend.sharedMaterial= materials[0];
    }


    public void ChangeColorToFirstColor()
    {
        rend.sharedMaterial = materials[0];
    }
    public void ChangeColorToSecondColor()
    {
        rend.sharedMaterial = materials[1];
    }
}
