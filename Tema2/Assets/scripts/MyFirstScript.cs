using System.Collections;
using System.Collections.Generic;
using UnityEngine; 


public class MyFirstScript : MonoBehaviour
{
    /*
    
    private float playerSpeed = 5.25f;
    public string playerName = "Jaume";
    [SerializeField] private bool gameOver;

    public int x = 5;
    public int y = 2;

    public float a = 5f;
    public float b = 2f;
    
    public bool isRaining = false;
    */
    
    public int playerAge = 35;

    // Start is called before the first frame update
    void Start()
    {
       /*
        Debug.Log($"Suma: {x + y}");
        Debug.Log("Resta: " + (x - y));
        Debug.Log($"Divide: { x / y}");
        Debug.Log($"Multiplica: {x * y}");
        Debug.Log(string.Format("Divide: {0} / {1} = {2}", x, y, x / y));
       


        if (isRaining == true) 
        {
            Debug.Log("Lleva paraguas");
        } else
        {
            Debug.Log("No llueve. No lleves paraguas");
        }*/

        if(playerAge >= 18)
        {
            Debug.Log("Eres mayor de edad");
        }else if (playerAge >= 13)
        {
            Debug.Log("Eres adolescente");
        }
        else
        {
            Debug.Log("Eres un niño");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
