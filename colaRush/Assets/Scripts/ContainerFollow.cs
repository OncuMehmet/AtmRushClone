using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;



public class ContainerFollow : MonoBehaviour
{
    [SerializeField] float second = 3.5f;
    GameObject target;
    Transform colaObject;
    GameObject parentObjectTween;
    

    // Start is called before the first frame update
    void Start()
    {
       
        colaObject = GetComponent<Transform>();
        target = GameObject.FindGameObjectWithTag("FollowObject");
        colaObject.transform.DOMove(target.transform.position, second);
        
        parentObjectTween = GameObject.FindGameObjectWithTag("kutuCola");
        

    }
    private void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (gameObject.CompareTag("Band") && other.gameObject.tag == "cola1Mesh"|| other.gameObject.tag == "cola3" || other.gameObject.tag == "PlasticCola" )
        {
            // Debug.Log("DEYDÝRDDÝÝÝÝÝ ALOOOO");
            other.gameObject.AddComponent<ContainerFollow>();
            
            
        }
        if(gameObject.CompareTag("cola1Mesh") && other.gameObject.tag == "FollowObject")
        {
           //Debug.Log("cola1MEsh Geldi");
       
            this.gameObject.SetActive(false);
            
         


        }
        if(gameObject.CompareTag("cola3") && other.gameObject.tag == "FollowObject")
        {
            //Debug.Log("cola3 Geldi");
            
            this.gameObject.SetActive(false);
            
          
        }
        if(gameObject.CompareTag("PlasticCola") && other.gameObject.tag == "FollowObject")
        {
           // Debug.Log("Plastic COla Geldi");
            
            this.gameObject.SetActive(false);
            

        }


        
    }
}
