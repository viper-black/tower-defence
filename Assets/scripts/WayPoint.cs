using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WayPoint : MonoBehaviour
{
    [SerializeField] bool isPlaceable;

    private void OnMouseDown() 
    {
        if(isPlaceable == true)
        {
  
        Debug.Log(transform.name);          
        }
    }
}

