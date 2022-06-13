using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
  

    [SerializeField] GameObject[] levelPrefabs;

    public static LevelManager Instance;

    public int levelNumber;
    MovementController movementController;

    private void Awake()
    {
        Instance = this;
        levelNumber = PlayerPrefs.GetInt("Level", 0);
        movementController = GetComponent<MovementController>();
    }

    private void Start()
    {
        LevelCreate();
       
    }

    public void LevelCompleted()
    {
        //levelNumber++;
        
        PlayerPrefs.SetInt("Level", levelNumber);
        Destroy(GameObject.FindGameObjectWithTag("Level"));

    }
    public void LevelCreate()
    {
        Instantiate(levelPrefabs[levelNumber % levelPrefabs.Length]);
        

    }
    public void LevelRetry()
    {
        
        Destroy(GameObject.FindGameObjectWithTag("Level"));
       
        Instantiate(levelPrefabs[0]);
       
    }
   

    

   
}
