using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // Agrega este using para manejar la interfaz de usuario en Unity

public class Puntuacion : MonoBehaviour
{
    public int totalPuntuacion = 0; // Variable para almacenar la puntuaci�n total
    public Text puntuacionTexto; // Referencia al texto en el que se mostrar� la puntuaci�n

    // M�todo para actualizar y mostrar la puntuaci�n
    public void ActualizarPuntuacion()
    {
        //puntuacionTexto.text = "Puntuaci�n: " + totalPuntuacion.ToString();
    }

    // Start is called before the first frame update
    void Start()
    {
        // Llama al m�todo para mostrar la puntuaci�n inicial al iniciar el juego
        ActualizarPuntuacion();
    }

    // Update is called once per frame
    void Update()
    {
        // Aqu� puedes agregar cualquier l�gica de actualizaci�n de la puntuaci�n que necesites
    }
}