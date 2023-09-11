using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class SIN : MonoBehaviour
{
    public Transform pointPrefab;

    #region 构造函数
    
    void Awake()
    {
        Vector3 position;
        position.y = 0f;
        position.z = 0f;
        for (int i = 0; i < 10; i++)
        {
            Transform point = Instantiate(pointPrefab);
            position.x = (i + 0.5f) / 5f - 1f;
            position.y = position.x * position.x;
            point.localPosition = position;
            //point.localScale = scale;
            Console.WriteLine("ezzzzz");

            //int aa = 3333;
            //float bv = Convert.ToByte(aa);
        }

    }
    #endregion
    
    
    
    // Update is called once per frame
    void Update()
    {
        
    }
}
