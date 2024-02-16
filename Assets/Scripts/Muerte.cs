using UnityEngine;

public class Muerte : MonoBehaviour
{
    public movimientolateral movimientolateral;

    // Este método se llama cuando otro collider entra en contacto con este collider
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (movimientolateral != null)
        {
            movimientolateral.muertepj();
            Debug.Log("ENTRANDO");
        }
        else
        {
            Debug.LogError("Movimiento lateral no asignado en Muerte.");
        }
    }
}