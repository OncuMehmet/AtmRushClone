using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddColliderAxe : MonoBehaviour
{
  

    private void OnTriggerEnter(Collider other)
    {
        if (gameObject.CompareTag("addColliderAxe") && other.gameObject.tag == "cola3" || other.gameObject.tag == "parentCola"|| other.gameObject.tag =="cola1Mesh")
        {
           // Debug.Log("ADD collider Axe 1");
            other.gameObject.AddComponent<ColliderController>();

           
            
        }
        if (gameObject.CompareTag("addColliderAxe") && other.gameObject.tag == "PlasticCola" || other.gameObject.tag == "cola3" || other.gameObject.tag == "parentCola" || other.gameObject.tag == "cola1Mesh"|| other.gameObject.tag == "Player")
        {
            //Debug.Log("Add Collider Axe 2");
            other.gameObject.AddComponent<ColliderController>();

            


        }
    }
}
