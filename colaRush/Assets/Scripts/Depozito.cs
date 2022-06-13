using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Depozito : MonoBehaviour
{
    [SerializeField] GameObject anaObje;
    [SerializeField] GameObject playerObje;
    List<GameObject> gameObjecTs;
    LevelManager levelManager;
    

    // Start is called before the first frame update
    void Start()
    {
        anaObje.SetActive(true);
        gameObjecTs = new List<GameObject>();
        levelManager = GetComponent<LevelManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {

        if (gameObject.CompareTag("cola1Mesh") && other.gameObject.CompareTag("Depozito"))
        {
            //Debug.Log("ÝÞTEE GELLDDDÝÝÝÝÝÝÝÝ");
            anaObje.SetActive(false);




        }
        if (gameObject.CompareTag("cola3") && other.gameObject.CompareTag("Depozito"))
        {
            // Debug.Log("Denemedeyizz");
            anaObje.SetActive(false);





        }
        if (gameObject.CompareTag("PlasticCola") && other.gameObject.CompareTag("Depozito"))
        {
            //Debug.Log("2.5 litre ");
            anaObje.SetActive(false);




        }
        if (gameObject.CompareTag("cola1Mesh") && other.gameObject.CompareTag("axe"))
        {

            //  anaObje.SetActive(false);
            gameObject.AddComponent<ColliderController>();
            playerObje.AddComponent<ColliderController>();
            
             anaObje.SetActive(false);
          
        }
        if (gameObject.CompareTag("cola3") && other.gameObject.CompareTag("axe"))
        {
           // Debug.Log("BaltayaGEldin");
            
            gameObject.AddComponent<ColliderController>();
            playerObje.AddComponent<ColliderController>();
            
            anaObje.SetActive(false);
          
        }

    
        if (gameObject.CompareTag("PlasticCola") && other.gameObject.CompareTag("axe"))
        {
           // Debug.Log("BaltayaGEldin");
           
            gameObject.AddComponent<ColliderController>();
            playerObje.AddComponent<ColliderController>();
            anaObje.SetActive(false);
           


        }
        if (gameObject.CompareTag("cola2") && other.gameObject.CompareTag("axe"))
        {
            Debug.Log("BaltayaGEldin");
            
            gameObject.AddComponent<ColliderController>();
            playerObje.AddComponent<ColliderController>();
            anaObje.SetActive(false);



        }


       



    }
   
}
