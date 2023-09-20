using UnityEngine;

namespace Project_Learning.Rocket.Script
{
    public class Movement : MonoBehaviour
    {
        private Rigidbody rb;
        [SerializeField] private float rcsThrust = 1000f;
        [SerializeField] private float rcsRotate = 100f;

        private void Start()
        {
            rb = GetComponent<Rigidbody>();
        }

        void Update()
        {
            ProcessRocketThrust();
            ProcessRocketRotate();
        }

        void ProcessRocketThrust()
        {
            if (Input.GetKey(KeyCode.Space))
            {
                rb.AddRelativeForce(Vector3.up * (rcsThrust * Time.deltaTime));
            }
        }

        void ProcessRocketRotate()
        {
            if (Input.GetKey(KeyCode.A))
            {
                ApplyRotation(rcsRotate);
            }
            else if (Input.GetKey(KeyCode.D))
            {
                ApplyRotation(-rcsRotate);
            }
            
        }

        private void ApplyRotation(float rotationThisFrame)
        {
            rb.freezeRotation = true; // freezing rotation so we can manually rotate
            transform.Rotate(Vector3.forward * (rotationThisFrame * Time.deltaTime));
            rb.freezeRotation = false; // unfreezing rotation so the physics system can take over
            
        }
    }
}

