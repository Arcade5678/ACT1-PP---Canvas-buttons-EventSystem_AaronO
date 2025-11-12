using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarradeVida : MonoBehaviour
{

    [SerializeField] Image barra;

    [SerializeField] Sprite sprite100; 
    [SerializeField] Sprite sprite80; 
    [SerializeField] Sprite sprite60;  
    [SerializeField] Sprite sprite40; 
    [SerializeField] Sprite sprite20;  
    [SerializeField] Sprite sprite0;   

    public void ControladorBarra(int vid )
    {

        if (vid == 100)
        {
            barra.sprite = sprite100;
        }
        if (vid == 80)
        {
            barra.sprite = sprite80;
        }
        if (vid == 60)
        {
            barra.sprite = sprite60;
        }
        if (vid == 40)
        {
            barra.sprite = sprite40;
        }
        if (vid == 20)
        {
            barra.sprite = sprite20;
        }
        if (vid == 0)
        {
            barra.sprite = sprite0;
        }

        // Opcional: Agrega Debug.Log para verificar el valor de vid y confirmar cambios
        Debug.Log("Vida actual: " + vid + ", Sprite asignada: " + barra.sprite.name);
    }
}
