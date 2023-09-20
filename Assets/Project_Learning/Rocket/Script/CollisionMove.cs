using Unity.Mathematics;
using UnityEngine;

public class CollisionMove : MonoBehaviour
{
    private Vector3 startPosition;
    [SerializeField] private Vector3 movementPosition;
    [SerializeField] [Range(0, 1)] float movementFactor;
    [SerializeField] private float timeScale = 2f;
    private Transform tf;

    void Start()
    {
        tf = GetComponent<Transform>();
        startPosition = tf.position;
    }

    void Update()
    {
        transformMove();
    }
    
    private void transformMove()
    {
        Vector3 offset = movementPosition * (movementFactor * math.sin(math.PI * Time.time * timeScale));
        transform.position = startPosition + offset;
    }
}