using UnityEngine;
using UnityEngine.SceneManagement;

public class InteraçãoPraia : MonoBehaviour
{
    public GameObject jogador;

    public GameObject botãoCasa;
    [SerializeField] float distanciaBotao;

    void Start ()
    {
        jogador = GameObject.Find("Jogador");
    }
    
    void Update ()
    {
        InteracaoEstruturas();

        distanciaBotao = Vector2.Distance(jogador.transform.position, botãoCasa.transform.position);
    }

    private void InteracaoEstruturas()
    {
        if (distanciaBotao < 2)
        {
            botãoCasa.SetActive(true);
        }
        else
        {
            botãoCasa.SetActive(false);
        }
    }
}