using System.Collections;
using System.Collections.Generic;
using UnityEngine; 


public class MyFirstScript : MonoBehaviour
{
    /*
    public int playerAge = 35;
    private float playerSpeed = 5.25f;
    public string playerName = "Jaume";
    [SerializeField] private bool gameOver;*/

    public int x = 5;
    public int y = 2;

    public float a = 5f;
    public float b = 2f;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log($"Suma: {x + y}");
        Debug.Log("Resta: " + (x - y));
        Debug.Log($"Divide: { x / y}");
        Debug.Log($"Multiplica: {x * y}");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
