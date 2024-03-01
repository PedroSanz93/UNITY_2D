using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class vidas : MonoBehaviour
{
    public int totalVidas;
    // Start is called before the first frame update
    public TMP_Text text;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        text.text = "Vidas: " + totalVidas;
    }
}
