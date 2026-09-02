using System.Collections;
using System.Threading;
using UnityEngine;





public class Prueba8ejercicios : MonoBehaviour
{
    float tiempo = 0;
    int segundos = 0;
    int duracion = 0;
    bool terminado = false;
    int segundosrestantes = 10;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }
    void LogicaCuentaRegresiva()
    {
        tiempo += Time.deltaTime;

        if (terminado == false)
        {
            tiempo += Time.deltaTime;

            if (tiempo >= 1)
            {

                segundosrestantes--;
                Debug.Log("Segundo: " + segundosrestantes);
                tiempo = 0;

                if (segundosrestantes <= duracion)
                {
                    terminado = true;
                    Debug.Log("Terminado");
                }

            }
        }
    }


    // Update is called once per frame
    void Update()
    {
    endtimer();
    //LogicaCuentaRegresiva();

    }
    void endtimer()
    {
        tiempo += Time.deltaTime;
        //endtimer();
        //Debug.Log ("Seg" + tiempoactual);
        if (terminado == false)
        {
            tiempo += Time.deltaTime;

            if (tiempo >= 1)
            {

                segundos++;
                Debug.Log("Segundo: " + segundos);
                tiempo = 0;

                if (segundos >= duracion)
                {
                    terminado = true;
                    Debug.Log("Terminado");
                }

            }
        }
    }
}
