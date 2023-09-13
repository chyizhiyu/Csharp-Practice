using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatorObj : MonoBehaviour
{

    [SerializeField] private float rotatospeed = 1f;
    void Update()
    {
        transform.rotation=Quaternion.Euler(0,transform.rotation.eulerAngles.y + rotatospeed,0);
    }
}
