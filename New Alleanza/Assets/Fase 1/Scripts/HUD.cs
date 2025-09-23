using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HUD : MonoBehaviour
{
    public void Inventario(GameObject mapa)
    {
        Time.timeScale = 0;
        mapa.SetActive(true);
    }
}
