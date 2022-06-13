using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Axe : MonoBehaviour
{
     Transform axeObject1;
   
    
    // Start is called before the first frame update
    void Start()
    {
        axeObject1 = GetComponent<Transform>();
       
        
        StartCoroutine(nameof(AxeRotate1));
        

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator AxeRotate1()
    {
        yield return new WaitForSeconds(0.1f);
        axeObject1.DORotate(new Vector3(0f, 0f, -85f), 0.3f); //0.5 saniyede bu iþlemi yap
        yield return new WaitForSeconds(0.28f);// 0.5 saniye bekle altýndaki iþleme geç
        axeObject1.DORotate(new Vector3(0f, 0f, 0f), 0.3f);
        yield return new WaitForSeconds(0.28f);
        StartCoroutine(nameof(AxeRotate1)); // iþlem döngü þeklinde olsun diye  reqursive fonksiyon yaptýk

    }
    





    IEnumerator CancelNumarator() //bir sonraki levele geçerken bunu kapatýcaz herhangi bir hata almamak için
    {
        yield return new WaitForSecondsRealtime(0.1f); //0.1 saniye dur sonra bura çalýþsýn
        CancelNumarator();
    }

    //private void OnTriggerEnter(Collider other)
    //{
    //    if (gameObject.CompareTag("axe") && other.gameObject.CompareTag("cola1Mesh"))
    //    {
    //        //Debug.Log("Baltaya DEYDÝN");
    //       // anaObject.SetActive(false);
    //    }
    //    if (gameObject.CompareTag("axe") && other.gameObject.CompareTag("cola3"))
    //    {
    //       // Debug.Log("Baltaya DEYDÝN");
    //       // anaObject.SetActive(false);
    //    }
    //    if (gameObject.CompareTag("axe") && other.gameObject.CompareTag("PlasticCola"))
    //    {
    //       // Debug.Log("Baltaya DEYDÝN");
    //       // anaObject.SetActive(false);
    //    }

    //}
}
