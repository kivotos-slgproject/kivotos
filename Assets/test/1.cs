using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class map1tes : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log($"int: 1111"); 
    }
    void OnMouseDown()
    {
        // Destroy the gameObject after clicking on it
        Debug.Log($"int: 12222{gameObject.name}"); 
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
