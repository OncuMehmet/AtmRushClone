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
        axeObject1.DORotate(new Vector3(0f, 0f, -85f), 0.3f); //0.5 saniyede bu i�lemi yap
        yield return new WaitForSeconds(0.28f);// 0.5 saniye bekle alt�ndaki i�leme ge�
        axeObject1.DORotate(new Vector3(0f, 0f, 0f), 0.3f);
        yield return new WaitForSeconds(0.28f);
        StartCoroutine(nameof(AxeRotate1)); // i�lem d�ng� �eklinde olsun diye  reqursive fonksiyon yapt�k

    }
    





    IEnumerator CancelNumarator() //bir sonraki levele ge�erken bunu kapat�caz herhangi bir hata almamak i�in
    {
        yield return new WaitForSecondsRealtime(0.1f); //0.1 saniye dur sonra bura �al��s�n
        CancelNumarator();
    }

    //private void OnTriggerEnter(Collider other)
    //{
    //    if (gameObject.CompareTag("axe") && other.gameObject.CompareTag("cola1Mesh"))
    //    {
    //        //Debug.Log("Baltaya DEYD�N");
    //       // anaObject.SetActive(false);
    //    }
    //    if (gameObject.CompareTag("axe") && other.gameObject.CompareTag("cola3"))
    //    {
    //       // Debug.Log("Baltaya DEYD�N");
    //       // anaObject.SetActive(false);
    //    }
    //    if (gameObject.CompareTag("axe") && other.gameObject.CompareTag("PlasticCola"))
    //    {
    //       // Debug.Log("Baltaya DEYD�N");
    //       // anaObject.SetActive(false);
    //    }

    //}
}
