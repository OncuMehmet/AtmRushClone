using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DepozitoSkor : MonoBehaviour
{
   public int depozitoSkor1;
   public int depozitoSkor2;
   public int depozitoSkor3;

   



    // Start is called before the first frame update
    void Start()
    {
        depozitoSkor1 = 0;
        depozitoSkor2 = 0;
        depozitoSkor3 = 0;

      
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.CompareTag("cola1Mesh") && gameObject.CompareTag("Depozito"))
        {
            depozitoSkor1++;
            depozitoSkor2++;
            depozitoSkor3++;
            Debug.Log(depozitoSkor1);
           

        }
        if (other.gameObject.CompareTag("cola3") && gameObject.CompareTag("Depozito"))
        {
            depozitoSkor1++;
            depozitoSkor2++;
            depozitoSkor3++;
            
            Debug.Log(depozitoSkor1);
        }
        if (other.gameObject.CompareTag("PlasticCola") && gameObject.CompareTag("Depozito"))
        {
            depozitoSkor1++;
            depozitoSkor2++;
            depozitoSkor3++;
            Debug.Log(depozitoSkor1);
        }

    }
}
