using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class Dead : MonoBehaviour
{
    MovementController movementController;
    [SerializeField] GameObject playerModel;
    Animator animator;
   
    void Start()
    {
        movementController = GetComponent<MovementController>();
        animator = playerModel.GetComponent<Animator>();
     
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (gameObject.CompareTag("Depozito") && other.gameObject.tag == "Player")
        {
            Debug.Log("DEPOZÝTO ÖLLL DAYI");
            
            other.gameObject.GetComponentInParent<MovementController>().enabled = false;
            animator.SetBool("isWalking", false);
            animator.SetBool("isDeath", true);
         
            
        }
    }
    IEnumerator levelRestart()
    {
        yield return new WaitForSeconds(5f);
        LevelManager.Instance.LevelRetry();
    }
}
