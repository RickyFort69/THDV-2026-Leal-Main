using System.Collections;
using System.Threading;
using UnityEditor.Experimental.GraphView;
using UnityEngine;





public class Prueba8ejercicios : MonoBehaviour
{
    float tiempo = 0;
    int segundos = 0;
    int duracion = 10;
    bool terminado = false;
    int segundosrestantes = 10;
    int[] arraypares = new int[5];
    int segundospares = 0;
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
        //evencount();
        paresmayoresde5();


    }
    void endtimer()
    {
        tiempo += Time.deltaTime;

        if (terminado == false)
        {
            tiempo += Time.deltaTime;

            if (tiempo >= 1)
            {

                segundos++;
                if (segundos % 2 == 0)
                {
                    Debug.Log(segundos + "Par");
                    arraypares[segundospares] = segundos;
                }
                else
                {
                    Debug.Log(segundos);
                    segundospares++;

                }

                tiempo = 0;

                if (segundos >= duracion)
                {
                    terminado = true;
                    Debug.Log("Terminado");
                    //mostrarpares();
                    
                    mostrarmayoresde5();


                }

            }
        }
    }

    void mostrarpares()
    {
        for (int i = 0; i < arraypares.Length; i++)
        {
            Debug.Log("Par: " + arraypares[i]);
        }

    }

    void paresmayoresde5()
    {
        while (terminado == false)
        {
            if (segundos % 2 == 0 && segundos > 5)
            {
                arraypares[segundospares] = segundos;


            }

            else if (segundos > 5)

            {

                segundospares++;

            }




        }

        

    }

    void mostrarmayoresde5()
    {
        Debug.Log(arraypares);
    }

 }

       


