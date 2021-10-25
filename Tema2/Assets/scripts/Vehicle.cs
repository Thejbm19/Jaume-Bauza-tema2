using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vehicle : MonoBehaviour
{
    //Variable que guarda el sonido del vehiculo
    [SerializeField]private string sound = "¡Brum,brum!";
    //Variable que gurada el nombre del GameObject
    [SerializeField]private string name = "";
    //Variable que guarda el numero de ruedas del GameObject o coche
    [SerializeField]private int numberWheels = 4;
    //Variable que guarda si la ambulancia tiene o no sirena
    [SerializeField] private bool hasSiren;
    //Variable indica si el vehiculo ha ararancado
    [SerializeField] private bool isOn = true;
    //Variable que mira si se cumple la condicion de true y true
    [SerializeField] private float gasoline;





    // Start is called before the first frame update
    void Start()
    {   /*
        Debug.Log($"{name} tiene {numberWheels} ruedas y hace {sound}");

        if (hasSiren == true)
        {
            Debug.Log($"{name} tiene sirena");
        }  else
        {
            Debug.Log($"{name} no tiene sirena");
        }



        if (isOn == true)
        {
            Debug.Log(sound);
        }
        else if (hasSiren == true)
        {
            Debug.Log($"{name} hara {sound} cuando se ponga en marcha");
        }
        else
        {
            Debug.Log($"{name} no esta en marcha");
        }*/

        if (gasoline < 10 && isOn == true)
        {
             Debug.Log($"¡A {name} le queda poca gasolina!");
              if (hasSiren == true)
            {
                Debug.Log(sound);
            }
              else
               {
                Debug.Log($"{name} no tiene sirena");
               }
        }
        else
        {
           if (isOn == false)
            {
                Debug.Log($"{name} no esta en marcha");
            }
        }

           
    }

    // Update is called once per frame
    void Update()
    {
        if (isOn == true)
        {
            if (Input.GetKeyDown(KeyCode.D))
            {
                transform.position += Vector3.right;
            }

            if (Input.GetKeyDown(KeyCode.A))
            {
                transform.position += Vector3.left;
            }

            if (Input.GetKeyDown(KeyCode.E))
            {
                transform.position += Vector3.up;
            }

            if (Input.GetKeyDown(KeyCode.Q))
            {
                transform.position += Vector3.down;
            }
        }
    }
}
