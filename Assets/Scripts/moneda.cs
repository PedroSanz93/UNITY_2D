using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moneda : MonoBehaviour
{
    public Puntuacion puntuacion; // Referencia al script de puntuación
    public AudioClip sonidoMoneda; // El sonido que quieres reproducir

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("El personaje me ha tocado");

        // Incrementa la puntuación total en 1
        puntuacion.totalPuntuacion += 1;

        // Reproduce el sonido de la moneda
     
        
            AudioSource.PlayClipAtPoint(sonidoMoneda, transform.position);
        

        // Destruye el objeto de la moneda
        Destroy(gameObject);

        // Actualiza la puntuación mostrada en pantalla
        puntuacion.ActualizarPuntuacion();
    }
}
