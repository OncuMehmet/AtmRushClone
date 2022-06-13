using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NodeMovement : MonoBehaviour
{
    public Transform childTransform;
    [SerializeField]float softSpeed=5f;

    
    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(
            Mathf.Lerp(transform.position.x, childTransform.position.x, Time.deltaTime * softSpeed),//yumu�ak ge�i�i sa�lad���m�z k�s�m
            childTransform.position.y,
            childTransform.position.z + 5


            );
    }
   
}
