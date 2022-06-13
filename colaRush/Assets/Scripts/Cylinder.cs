using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Cylinder : MonoBehaviour
{
    [SerializeField]Transform cylinderTransform;
    // Start is called before the first frame update
    void Start()
    {
        cylinderTransform = GetComponent<Transform>();
      //  StartCoroutine(nameof(CylinderRotate1));
    }

    // Update is called once per frame
    void Update()
    {
       // cylinderTransform.transform.rotation = Quaternion.Euler(180, 0, 0);
    }
    //IEnumerator CylinderRotate1()
    //{
    //    yield return new WaitForSeconds(0.1f);
    //    cylinderTransform.DORotate(new Vector3(180f,0f,0f), 0.25f); //0.5 saniyede bu iþlemi yap
    //    yield return new WaitForSeconds(0.1f);
    //    StartCoroutine(nameof(CylinderRotate1)); // iþlem döngü þeklinde olsun diye  reqursive fonksiyon yaptýk

    //}
}
