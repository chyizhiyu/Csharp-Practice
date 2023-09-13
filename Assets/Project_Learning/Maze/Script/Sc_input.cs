using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sc_input : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }
    [SerializeField] private float speed = 1f;
    //三个toggle,分别是冻结x,冻结y,冻结z
    [SerializeField] private bool toggleX = false;
    [SerializeField] private bool toggleY = false;
    [SerializeField] private bool toggleZ = false;
    
    // Update is called once per frame
    void Update()
    {
        MoveCube();
    }

    public void MoveCube()
    {
        transform.Translate(new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical")) * speed * Time.deltaTime);
        //判断如果冻结x轴,则将x轴旋转角度设为0
        if (toggleX)
        {
            transform.rotation = Quaternion.Euler(0, transform.rotation.eulerAngles.y, transform.rotation.eulerAngles.z);
        }
        //如果冻结y轴,则将y轴旋转角度设为0
        if (toggleY)
        {
            transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles.x, 0, transform.rotation.eulerAngles.z);
        }
        //如果冻结z轴,则将z轴旋转角度设为0
        if (toggleZ)
        {
            transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles.x, transform.rotation.eulerAngles.y, 0);
        }

    }
    
    
}
