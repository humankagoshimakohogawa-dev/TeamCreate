using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class ChangeColorScript : MonoBehaviour
{   
    public Material MyColor;
    
    void OnMouseEnter()
    {
        GetComponent<Renderer>().material.color = Color.aliceBlue;
    }

    void OnMouseExit()
    {
        GetComponent<Renderer>().material.color = Color.gray;
    }

    void OnMouseDown()
    {
        GetComponent<Renderer>().material.color = Color.yellow;
    }

    void OnMouseUp()
    {
        GetComponent<Renderer>().material.color = Color.orange;
    }
}
