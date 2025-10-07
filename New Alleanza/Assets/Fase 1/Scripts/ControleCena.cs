using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControleCena : MonoBehaviour
{
    [SerializeField] GameObject inventario;
    [SerializeField] GameObject mapa;
    [SerializeField] GameObject botaoFechaInv;

    void Awake()
    {
        inventario.SetActive(false);
        mapa.SetActive(false);
        botaoFechaInv.SetActive(false);
    }

    public void SceneBeach()
    {
        SceneManager.LoadScene("Praia");
    }

    public void SceneMinigame()
    {
        SceneManager.LoadScene("Minigame");
    }

    public void SceneTopDraft()
    {
        SceneManager.LoadScene("TopDown");
    }

    public void InventarioAbre()
    {
        inventario.SetActive(true);
        botaoFechaInv.SetActive(true);
        Time.timeScale = 0;
    }

    public void inventarioFecha()
    {
        inventario.SetActive(false);
        botaoFechaInv.SetActive(false);
        Time.timeScale = 0;
    }

    public void MapaAbre()
    {
        mapa.SetActive(true);
        Time.timeScale = 0;
    }

    public void MapaFecha()
    {
        mapa.SetActive(false);
        Time.timeScale = 0;
    }
}