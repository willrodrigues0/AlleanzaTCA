using UnityEngine;
using UnityEngine.SceneManagement;

public class InteraçãoItens : MonoBehaviour
{
    public GameObject mochila, mochilaInteracao;
    public GameObject mapa, mapaInteracao;
    public float distanciaMochila, distanciaMapa;

    string nomeCena;

    void Start ()
    {
        nomeCena = SceneManager.GetActiveScene().name;
    }

    void Update()
    {
        InteracaoFerramentas();

        distanciaMochila = Vector2.Distance(transform.position, mochila.transform.position);
        distanciaMapa = Vector2.Distance(transform.position, mapa.transform.position);
    }
    
    void InteracaoFerramentas ()
    {
        if (distanciaMochila < 2)
        {
            mochilaInteracao.SetActive(true);
        }
        else
        {
            mochilaInteracao.SetActive(false);
        }

        if (distanciaMapa < 2)
        {
            mapaInteracao.SetActive(true);
        }
        else
        {
            mapaInteracao.SetActive(false);
        }
    }
}