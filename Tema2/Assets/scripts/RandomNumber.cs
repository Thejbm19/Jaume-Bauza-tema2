using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RandomNumber : MonoBehaviour
{
     
     
     private int randNum;
     private int myNum;
     private int counter; //Contador de intentos

    // Start is called before the first frame update
    void Start()
    {
        randNum = Random.Range(0, 11);

    }

    // Update is called once per frame
    void Update()
    {   
        if (Input.GetKeyDown(KeyCode.Return))
        {
            myNum = int.Parse(GetComponent<InputField>().text);
            CompareToNumberRandom(myNum);
            counter++;   //sumar 1 counter
        }

    }


    public void CompareToNumberRandom(int userNum)
    {
        if (userNum > randNum)
        {
            Debug.Log("El numero que yo habia pensado es mas pequeño");
        }

        if (userNum < randNum)
        {
            Debug.Log("El numero que yo habia pensado es mas grande");
        }

        if (userNum == randNum)
        {
            Debug.Log($"HAS ACERTADO El numero que habia pensado era el {randNum}");
            Debug.Log($"Has utilizado {counter} intentos");
        }
    }
}
