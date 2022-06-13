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
        if (other.gameObject.CompareTag("parentCola"))//�arpt���n parentCola ise
        {
           other.gameObject.GetComponent<DOTweenManager>().objectScaleVibrator();
          //  Debug.Log("�al��t��");
            other.gameObject.transform.position = transform.position + new Vector3(0,0,0.55f);
          // Debug.Log("Burada tamam");
            
            Destroy(gameObject.GetComponent<ColliderController>());
                                                   //Bunu neden yapt�k hep ileri do�ru eklemesi i�in bir arkadaki toplama scripti kapanacakki hep �ne eklesin
            other.gameObject.AddComponent<ColliderController>(); //bir �ndekine scripti ekliyoruzki oda toplayabilsin
            
            other.gameObject.GetComponent<BoxCollider>().isTrigger = false;//listemize ekledi�imiz objenin isTrigger�n� kapat�caz
            other.gameObject.AddComponent<NodeMovement>();
            other.gameObject.GetComponent<NodeMovement>().childTransform = transform;
            other.gameObject.tag = "kutuCola";//tag� de�i�tiriyoruz yan tarafdan �arpmalarda problem olmamas� i�in
        }



    }
    
}
