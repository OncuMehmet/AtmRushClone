using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddCollider : MonoBehaviour
{
   // [SerializeField] GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (gameObject.CompareTag("addCollider") && other.gameObject.tag =="cola3" ||other.gameObject.tag=="parentCola")
        {
           // Debug.Log("ADD COLLÝDER DAYII");
            other.gameObject.AddComponent<ColliderController>();
            
            
            Destroy(gameObject);
        }
        if (gameObject.CompareTag("addCollider") && other.gameObject.tag == "PlasticCola" || other.gameObject.tag=="cola3"|| other.gameObject.tag == "parentCola")
        {
           // Debug.Log("Add Collider 2");
            other.gameObject.AddComponent<ColliderController>();
            
            
            Destroy(gameObject);

        }
    }
}
