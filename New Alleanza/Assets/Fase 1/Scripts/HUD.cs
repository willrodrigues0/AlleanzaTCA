using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HUD : MonoBehaviour
{
    //SISTEMA DE FERRAMENTAS
    [SerializeField] GameObject mapa;
    [SerializeField] GameObject inventario;
    [SerializeField] GameObject UI;

    private void Awake()
    {
        mapa.SetActive(false);
        inventario.SetActive(false);
        UI.SetActive(true);
    }

    public void MapaAbre()
    {
        mapa.SetActive(true);
        UI.SetActive(false);
    }

    public void MapaFecha()
    {
        mapa.SetActive(false);
        UI.SetActive(true);
    }

    public void InventarioAbre()
    {
        inventario.SetActive(true);
        UI.SetActive(false);
    }

    public void InventarioFecha()
    {
        inventario.SetActive(false);
        UI.SetActive(true);
    }

    //SISTEMA PAUSE
    public GameObject PauseMenu;
    public GameObject ConfigMenu;
    public bool isPause;

    void Start()
    {
        PauseMenu.SetActive(false);
    }

    public void PauseGame()
    {
        PauseMenu.SetActive(true);
        Time.timeScale = 0f;

        UI.SetActive(false);
    }

    public void ResumeGame()
    {
        PauseMenu.SetActive(false);
        Time.timeScale = 1f;

        UI.SetActive(true);
    }

    public void AbrirMenuConfig ()
    {
        ConfigMenu.SetActive(true);
        PauseMenu.SetActive(false);
    }

    public void FechaManuConfig ()
    {
        ConfigMenu.SetActive (false);
        PauseMenu.SetActive (true);
    }

    public void Sair ()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("MenuPrincipal");
    }
}