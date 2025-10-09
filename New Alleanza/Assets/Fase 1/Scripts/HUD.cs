using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HUD : MonoBehaviour
{
    [SerializeField] GameObject mapa;
    [SerializeField] GameObject inventario;
    [SerializeField] GameObject UI;

    private void Start()
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
}