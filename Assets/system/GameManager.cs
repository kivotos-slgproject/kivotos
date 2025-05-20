using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
我在那这个文件我拿来学C#和做测试用，不用在意
*/
public class Character1 { 
    public int Data1;
    public string Data2;
}

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    Character1 test = new Character1();
    void Awake()
    {
        test.Data1 = 1;
        test.Data2 = "test";
        Debug.Log($"int: {test.Data1}"); 
        Debug.Log($"str: {test.Data2}"); 
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log($"str: {test.Data2}"); 
    }
}
