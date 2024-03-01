using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI; // Agrega este using para manejar la interfaz de usuario en Unity

public class Puntuacion : MonoBehaviour
{
    public int totalPuntuacion = 0; // Variable para almacenar la puntuaci�n total
    //public Text puntuacionTexto; // Referencia al texto en el que se mostrar� la puntuaci�n
    public TMP_Text text;

    // M�todo para actualizar y mostrar la puntuaci�n
    public void ActualizarPuntuacion()
    {
        //puntuacionTexto.text = "Puntuaci�n: " + totalPuntuacion.ToString();
    }

    // Start is called before the first frame update
    void Start()
    {
        // Llama al m�todo para mostrar la puntuaci�n inicial al iniciar el juego

    }

    // Update is called once per frame
    void Update()
    {
        //ActualizarPuntuacion();
        text.text = "Puntos: " + totalPuntuacion;
    }

}