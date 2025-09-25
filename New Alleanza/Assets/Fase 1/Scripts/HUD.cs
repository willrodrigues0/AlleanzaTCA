using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HUD : MonoBehaviour
{
    public void InventarioAbre(GameObject mapa)
    {
        mapa.SetActive(true);
    }

    public void InventarioFecha(GameObject mapa)
    {
        mapa.SetActive(false);
    }
}
