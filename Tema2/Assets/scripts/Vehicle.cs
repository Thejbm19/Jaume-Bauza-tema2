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
    [SerializeField] private bool hasSiren = false;

    [SerializeField] private bool isOn = true;







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
        }*/

        if (isOn == true)
        {
            Debug.Log($"{sound}");
        }
        else if (hasSiren == true)
        {
            Debug.Log($"{name} no esta en marcha");
        }
        else
        {
            Debug.Log($"{name} hara {sound} cuando se ponga en marcha");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
