using UnityEngine;

public class Visao : MonoBehaviour
{
    public Transform alvo;
    bool seguir;

    GameObject jogador;

    void Start ()
    {
        jogador = GameObject.Find("Jogador");
    }

    void Update()
    {
        Seguir();

        if (jogador.GetComponent<Jogador2D_Terra>().nameScene == "MorganHouse")
        {
            QuartoSeguir ();
        } 
    }

    /*void Seguir ()
    {
        if (jogador.GetComponent <Jogador2D_Terra> ().CamSeguindo)
        {
            transform.position = new Vector3 (alvo.position.x, alvo.position.y, transform.position.z);
            Camera.main.orthographicSize = 5;
        }
        else
        {
            transform.position = jogador.GetComponent <Jogador2D_Terra> ().destinoCam;
            Camera.main.orthographicSize = 8;
        }
    }*/

    void QuartoSeguir()
    {
        transform.position = new Vector3 (alvo.transform.position.x, -0.08999968f, transform.position.z);
    }

    void Seguir()
    {
        if (transform.position.x != -26.75f)
        {
            seguir = true;
        }
        else if (transform.position.x == -26.75f)
        {
            seguir = false;
        }

        if (seguir)
        {
            transform.position = new Vector3(alvo.position.x, alvo.position.y, transform.position.z);
        }
        else
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
        }
    }
}