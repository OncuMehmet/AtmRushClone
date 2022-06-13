using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class MovementController : MonoBehaviour
{
    PlayerInput playerInput;

    Vector3 playerMovementValue;
    [SerializeField] float zMove = 2f;
    [SerializeField] float playerMovementSpeed = 1f;
    [SerializeField] float xValue = 2f;
    [SerializeField] GameObject playerModel; //player objemiz alt objede diye direk burdan atama yapıcaz child obje Animasyon için
    Animator animator;//animasyonlara ulaşmak için
    

    void Awake()
    {

        playerInput = new PlayerInput();



    }
    // Start is called before the first frame update
    void Start()
    {
       
        playerMovementValue = new Vector3(0f, 0f, zMove);
        animator = playerModel.GetComponent<Animator>(); //Dışardan Serilizefield ile erişeceğimiz player model
        
        playerInput.Movement.Move.started += playerMovementStarted;
        playerInput.Movement.Move.performed += playerMovementStarted;
        playerInput.Movement.Move.canceled += playerMovementCanceled;
    }

    public void playerMovementStarted(InputAction.CallbackContext context)
    {
        playerMovementValue = new Vector3(context.ReadValue<Vector2>().x*xValue, 0f, zMove);
        
    }
    void playerMovementCanceled(InputAction.CallbackContext context)
    {
        playerMovementValue = new Vector3(0f, 0f, zMove);
    }

    void OnEnable() //new input systemi aktiv ediyoruz
    {
        playerInput.Enable();
    }
    void OnDisable()
    {
        playerInput.Disable();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(playerMovementSpeed * playerMovementValue * Time.deltaTime);
        
    }
    public void deathAnimation()
    {
        animator.SetBool("isDeath", true); //Ölüm animasyonunu başlat yürümek istersekde ölümü kapat çünkü sürekli yürüoruz zaten
    
    }
    private void OnTriggerEnter(Collider other)
    {
        if (gameObject.tag == "Player" && other.gameObject.CompareTag("Death"))//Çarpan obje player nere death alanına
        {
            Debug.Log("Deydi dayı");
            moveStop();
            deathAnimation();

        }
    }

    public void moveStop()
    {
        

        playerMovementValue = Vector3.zero;

        
    }
    public void moveStartRepating()
    {
        
            playerMovementValue = new Vector3(0f, 0f, zMove);
        
    }
    
}