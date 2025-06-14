using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log($"int: 1111"); 
    }
    void OnMouseDown()
    {
        // Destroy the gameObject after clicking on it
        Debug.Log($"int: 12222"); 
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
