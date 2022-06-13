using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColaUpdateCheck2 : MonoBehaviour
{
    [SerializeField] GameObject kutuCola;
    [SerializeField] GameObject plasticCola;


    void Start()
    {
        
    }


    private void OnTriggerEnter(Collider other)
    {
        if (gameObject.CompareTag("cola3") && other.gameObject.tag == "updateCola")
        {
            Debug.Log("Cola 3 Geldi DAYII ");
            kutuCola.SetActive(false);
            plasticCola.SetActive(true);

            
        }
        if (gameObject.CompareTag("PlasticCola") && other.gameObject.tag == "updateCola")
        {
            Debug.Log("Cola Plastic Geldi DAYII ");
            kutuCola.SetActive(false);
            plasticCola.SetActive(true);
            
            

            

        }

    }
   
}
