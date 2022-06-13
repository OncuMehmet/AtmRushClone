using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderController : MonoBehaviour
{
    DOTweenManager dgTweenObje;
    

    // Start is called before the first frame update
    void Start()
    {
        dgTweenObje = GetComponent<DOTweenManager>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("parentCola"))//çarptýðýn parentCola ise
        {
           other.gameObject.GetComponent<DOTweenManager>().objectScaleVibrator();
          //  Debug.Log("Çalýþtýý");
            other.gameObject.transform.position = transform.position + new Vector3(0,0,0.55f);
          // Debug.Log("Burada tamam");
            
            Destroy(gameObject.GetComponent<ColliderController>());
                                                   //Bunu neden yaptýk hep ileri doðru eklemesi için bir arkadaki toplama scripti kapanacakki hep öne eklesin
            other.gameObject.AddComponent<ColliderController>(); //bir öndekine scripti ekliyoruzki oda toplayabilsin
            
            other.gameObject.GetComponent<BoxCollider>().isTrigger = false;//listemize eklediðimiz objenin isTriggerýný kapatýcaz
            other.gameObject.AddComponent<NodeMovement>();
            other.gameObject.GetComponent<NodeMovement>().childTransform = transform;
            other.gameObject.tag = "kutuCola";//tagý deðiþtiriyoruz yan tarafdan çarpmalarda problem olmamasý için
        }



    }
    
}
