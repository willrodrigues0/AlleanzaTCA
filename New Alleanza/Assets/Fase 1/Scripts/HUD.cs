using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HUD : MonoBehaviour
{
    [SerializeField] GameObject mapa;
    [SerializeField] GameObject inventario;

    private void Start()
    {
        mapa.SetActive(false);
        inventario.SetActive(false);
    }

    public void MapaAbre()
    {
        mapa.SetActive(true);
    }

    public void MapaFecha()
    {
        mapa.SetActive(false);
    }

    public void InventarioAbre()
    {
        inventario.SetActive(true);
    }

    public void InventarioFecha()
    {
        inventario.SetActive(false);
    }
}