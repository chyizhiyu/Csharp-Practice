using UnityEngine;

public class CollisionEvent : MonoBehaviour
{

    [SerializeField] private Color collisionColor = Color.red;
    
    private bool ishitted;
    public int Hit = 0;
    
    void OnCollisionEnter(Collision other)
    {
        if(ishitted) return;

        if (other.gameObject.CompareTag("Player"))
        {
            GetComponent<Renderer>().material.color = collisionColor;
            ishitted = true;
            Hit++;
            Debug.Log("呀,你碰到我" + Hit + "次了!");
        }
        
    }
    
}
