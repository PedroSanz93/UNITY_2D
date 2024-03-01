using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI; // Agrega este using para manejar la interfaz de usuario en Unity

public class Puntuacion : MonoBehaviour
{
    public int totalPuntuacion = 0; // Variable para almacenar la puntuación total
    //public Text puntuacionTexto; // Referencia al texto en el que se mostrará la puntuación
    public TMP_Text text;

    // Método para actualizar y mostrar la puntuación
    public void ActualizarPuntuacion()
    {
        //puntuacionTexto.text = "Puntuación: " + totalPuntuacion.ToString();
    }

    // Start is called before the first frame update
    void Start()
    {
        // Llama al método para mostrar la puntuación inicial al iniciar el juego

    }

    // Update is called once per frame
    void Update()
    {
        //ActualizarPuntuacion();
        text.text = "Puntos: " + totalPuntuacion;
    }

}