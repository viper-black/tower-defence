using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

[ExecuteAlways]
public class coordinateLabeler : MonoBehaviour
{
    TextMeshPro label;
    Vector2Int Coordinates = new Vector2Int();
    void Awake() 
    {
        label = GetComponent<TextMeshPro>();    
        DisplayCoordinates();
    }
    void Update()
    {
        if(!Application.isPlaying)
        {
            DisplayCoordinates();
            NameChanger();
        }
    }
    void DisplayCoordinates()
    {
        Coordinates.x = Mathf.RoundToInt(transform.parent.position.x / UnityEditor.EditorSnapSettings.move.x);
        Coordinates.y = Mathf.RoundToInt(transform.parent.position.z  / UnityEditor.EditorSnapSettings.move.z);

        label.text = Coordinates.x + "," + Coordinates.y;
    }

    void NameChanger()
    {
        gameObject.transform.parent.name = Coordinates.ToString();
    }

}

