using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColaUpdateCheck : MonoBehaviour
{
    [SerializeField] GameObject glassCola;
    [SerializeField] GameObject kutuCola;
    [SerializeField] GameObject plasticCola;
   
 


    // Start is called before the first frame update
    void Start()
    {
        
        glassCola.SetActive(true);
        kutuCola.SetActive(false);
        plasticCola.SetActive(false);
    }

    
    private void OnTriggerExit(Collider other)
    {


        if (gameObject.CompareTag("cola2") && other.gameObject.tag == "updateCola")
        {
            
            Debug.Log("Kola2 Deydiiii");
            glassCola.SetActive(false);
            // Debug.Log("Glass Calýstý");

            //Debug.Log("Kutuda  Calýstý");

            kutuCola.SetActive(true); //kutu kolayý gostericez
            kutuCola.tag = "cola3";
            
        } 
       



    }
    

}
