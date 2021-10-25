using System.Collections;
using System.Collections.Generic;
using UnityEngine; 


public class MyFirstScript : MonoBehaviour
{
    /*
    
    private float playerSpeed = 5.25f;
    public string playerName = "Jaume";
    [SerializeField] private bool gameOver;

    

    public float a = 5f;
    public float b = 2f;
    
    public bool isRaining = false;
    public bool isCold;
    /*
    public int playerAge = 35;
    public int x = 5;
    public int y = 2;*/

    // Start is called before the first frame update

    public string hello;

    void Start()
    {
        HelloWorld();
        
        hello = GetHello();
        Debug.Log(hello);

       // Debug.Log(GetHello());

       // primer eje x segon eje y i tercer eje z
       // transform.position = new Vector3(0,0,0);
        transform.position = Vector3.one;
        Debug.Log(transform.position);
        
        /*if (isRaining == true)
        {   
            if (isCold == true)
            {
                Debug.Log("Lleva paraguas y sudadera");
            }
            else
            {
                Debug.Log("Lleva paraguas");
            }
                
        }
        else
        {
            if (isCold == true)
            {
                Debug.Log("Lleva una sudadera");
            }
            else
            {
                Debug.Log("Disfruta del dia");
            }
        }


        /*
         Debug.Log($"Suma: {x + y}");
         Debug.Log("Resta: " + (x - y));
         Debug.Log($"Divide: { x / y}");
         Debug.Log($"Multiplica: {x * y}");
         Debug.Log(string.Format("Divide: {0} / {1} = {2}", x, y, x / y));

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
         }*/
        /*
       if (x == 2 || y <=5)
       {
           Debug.Log("Verdadero");
       }
       else
       {
           Debug.Log("Falso");
       }    */




    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(transform.position);
        // linies per moure es GameObject
        if (Input.GetKeyDown(KeyCode.D))
        {
            transform.position += Vector3.right;
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            transform.position += Vector3.left;
            // transform.position += -1 * Vector3.right;
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            transform.position += Vector3.up;
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            transform.position += Vector3.down;
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            transform.position += Vector3.forward;
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            transform.position += Vector3.back;
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.rotation *= Quaternion.Euler(0, 10, 0);
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.rotation *= Quaternion.Euler(0, -10, 0);
        }

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            transform.rotation *= Quaternion.Euler(10, 0, 0);
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            transform.rotation *= Quaternion.Euler(0, 0, 10);
        } 

        if (Input.GetKeyDown(KeyCode.R))
        {
            transform.localScale += Vector3.right;
        }
    }


    public void HelloWorld()
    {
        Debug.Log("Hola, Mundo");
    }

    public string GetHello()
    {
        return "Hola";
    }
}
