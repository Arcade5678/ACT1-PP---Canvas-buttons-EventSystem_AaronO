using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControladorBotones : MonoBehaviour
{
    private int vida;
    private bool viu;

    [SerializeField] BarradeVida barradeVida;

    [SerializeField] Button buttonRevivir;
    [SerializeField] Button buttonMorir;
    [SerializeField] Button buttonCurar;
    [SerializeField] Button buttonDañar;

    [SerializeField] SpriteRenderer PerroSanche;

    [SerializeField] Sprite SancheVivo;
    [SerializeField] Sprite SancheMuerto;

    public void Start()
    {
        vida = 100;
        viu = true;

        if (buttonRevivir != null)
        {
            buttonRevivir.onClick.AddListener(Revivir);
        }
        if (buttonMorir != null)
        {
            buttonMorir.onClick.AddListener(Morir);
        }
        if (buttonCurar != null)
        {
            buttonCurar.onClick.AddListener(Curar);
        }
        if (buttonDañar != null)
        {
            buttonDañar.onClick.AddListener(Dañar);
        }
        CambioDeEstadoBotton();
    }



    public void Revivir()
    {
        vida = 100;
        viu = true;
        barradeVida.ControladorBarra(vida);
        CambioDeEstadoBotton();
        PerroSanche.sprite = SancheVivo;
    }

    public void Morir()
    {
        vida = 0;
        viu = false;
        barradeVida.ControladorBarra(vida);
        CambioDeEstadoBotton();
        PerroSanche.sprite = SancheMuerto;
    }

    public void Curar()
    {
        if (vida > 0 && vida < 100) {
            vida += 20;
        }
        barradeVida.ControladorBarra(vida);
        CambioDeEstadoBotton();
    }

    public void Dañar()
    {
        if (vida > 0 && vida <= 100)
        {
            vida -= 20;
        }
        if (vida == 0)
        {
            PerroSanche.sprite = SancheMuerto;
            viu = false;
        }
        barradeVida.ControladorBarra(vida);
        CambioDeEstadoBotton();

    }

    private void CambioDeEstadoBotton()
    {
        if (buttonMorir != null)
        {
            buttonMorir.interactable = viu; 
        }
        if (buttonRevivir != null)
        {
            buttonRevivir.interactable = !viu; 
        }
    }

}
