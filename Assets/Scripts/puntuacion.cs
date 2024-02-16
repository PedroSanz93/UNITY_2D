using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // Agrega este using para manejar la interfaz de usuario en Unity

public class Puntuacion : MonoBehaviour
{
    public int totalPuntuacion = 0; // Variable para almacenar la puntuación total
    public Text puntuacionTexto; // Referencia al texto en el que se mostrará la puntuación

    // Método para actualizar y mostrar la puntuación
    public void ActualizarPuntuacion()
    {
        //puntuacionTexto.text = "Puntuación: " + totalPuntuacion.ToString();
    }

    // Start is called before the first frame update
    void Start()
    {
        // Llama al método para mostrar la puntuación inicial al iniciar el juego
        ActualizarPuntuacion();
    }

    // Update is called once per frame
    void Update()
    {
        // Aquí puedes agregar cualquier lógica de actualización de la puntuación que necesites
    }
}