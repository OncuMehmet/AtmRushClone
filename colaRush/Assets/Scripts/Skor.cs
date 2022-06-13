using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Skor : MonoBehaviour
{
    TextMeshProUGUI skor_txt;
     int skor = 0;
    // Start is called before the first frame update
    void Start()
    {
        skor_txt = GameObject.Find("GameMaster/Canvas2/skor_txt").GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
      
    }
    private void OnTriggerEnter(Collider other)
    {
       
        if (other.gameObject.CompareTag("cola1Mesh") && gameObject.tag == "SkorTopla")
        {
           // Debug.Log("TOPLA 20");

            
            skor += 20;
          //  Debug.Log(skor);
            skor_txt.text = "SKOR: " + skor.ToString();



        }
        if (other.gameObject.CompareTag("cola3") && gameObject.tag == "SkorTopla")
        {
            //Debug.Log("TOPLA 30");


            skor += 30;
             skor_txt.text = "SKOR: " + skor.ToString();
           // Debug.Log(skor);
        }
        if (other.gameObject.CompareTag("PlasticCola") && gameObject.tag == "SkorTopla")
        {
            Debug.Log("TOPLA 40");


            skor += 40;
             skor_txt.text = "SKOR: " + skor.ToString();
           // Debug.Log(skor);
        }



    }

}
