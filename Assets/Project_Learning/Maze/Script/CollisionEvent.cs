using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class CollisionEvent : MonoBehaviour
{
    // Start is called before the first frame update
    //序列化一个颜色
    [SerializeField] private Color collisionColor = Color.red;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    
    void OnCollisionEnter(Collision other)
    {
        //判断碰撞的物体是否是玩家
        if (other.gameObject.CompareTag("Player"))
        {
            GetComponent<Renderer>().material.color = collisionColor;
        }
    }
}
