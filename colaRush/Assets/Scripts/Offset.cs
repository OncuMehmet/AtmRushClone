using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Offset : MonoBehaviour
{
    MeshRenderer mesh;
    [SerializeField]float scroolSpeed = 3f;


    // Start is called before the first frame update
    void Start()
    {
        mesh = GetComponent<MeshRenderer>();
        
    }

    // Update is called once per frame
    void Update()
    {
        float offset = Time.time * scroolSpeed; //x ynende 
        mesh.material.SetTextureOffset("_MainTex", new Vector2(-offset,0));//prototype metaryel ismi offset de ilk de�er x de�eri x de hareket edecek

    }

}
