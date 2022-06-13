using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;


public class DOTweenManager : MonoBehaviour
{
    

    Transform colaObjectTr;
    
    
    
    

    
    void Start()
    {
        DOTween.Init();
        DOTween.SetTweensCapacity(6000, 200);
        colaObjectTr = GetComponent<Transform>();
        
        

    }

    
    void Update()
    {
        
    }
    public void objectScaleVibrator()
    {
        colaObjectTr.DOPunchScale(Vector3.one * 0.06f, 3.5f, 2, 2);
    }

    
    




}
