using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
using TMPro;

public class FinishLine : MonoBehaviour
{
    MovementController movementController;
    Animator animator;
    [SerializeField] GameObject playerModel;
    TextMeshProUGUI winPanel;


    // Start is called before the first frame update
    void Start()
    {
        movementController = GetComponent<MovementController>();
        animator = playerModel.GetComponent<Animator>(); //Dýþardan Serilizefield ile eriþeceðimiz player model
        winPanel = GameObject.Find("GameMaster/Canvas2/Win_txt").GetComponent<TextMeshProUGUI>();
       

    }

    private void OnTriggerEnter(Collider other)
    {
        if (gameObject.CompareTag("FinishLine") && other.gameObject.tag == "Player")
        {
            Debug.Log("FÝNÝSH GELDÝÝ ALOOOO");
            other.gameObject.GetComponentInParent<MovementController>().enabled = false;
            animator.SetBool("isWalking", false);
            
            animator.SetBool("isStop", true);

            
            Invoke("danceStart1", 1f);
            Invoke("LevelComplate1", 17.5f);
           

        }
    }

    
    public void danceStart1()
    {
        animator.SetBool("isStop", false);
        animator.SetBool("isDancing", true);
    }
    public void LevelComplate1()
    {
        LevelManager.Instance.LevelCompleted();
        winPanel.gameObject.SetActive(true);

    }
    public void levelCreate()
    {
        LevelManager.Instance.LevelCreate();
    }
}
