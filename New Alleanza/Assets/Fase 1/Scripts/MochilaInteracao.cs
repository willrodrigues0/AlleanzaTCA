using UnityEngine;
using TMPro;
using System.Collections;

public class MochilaInteracao : MonoBehaviour
{
    [Header("Referências da Mochila")]
    public GameObject inventarioButton;  
    public GameObject MochilaCenario;    

    [Header("Diálogo")]
    [TextArea]
    public string dialogueText;          
    public GameObject dialogueUI;        
    public TMP_Text dialogueUIText;      

    public void PegarMochila()
    {
        // ativa o botão do inventário
        if (inventarioButton != null)
            inventarioButton.SetActive(true);

        // mostra o diálogo
        if (dialogueUI != null && dialogueUIText != null)
        {
            dialogueUI.SetActive(true);
            dialogueUIText.text = dialogueText;
        }

        // inicia a coroutine para fechar o diálogo e desativar a mochila depois
        StartCoroutine(FecharDialogoAposTempo(3f));
    }

    private IEnumerator FecharDialogoAposTempo(float tempo)
    {
        yield return new WaitForSeconds(tempo);

        // fecha o diálogo
        if (dialogueUI != null)
            dialogueUI.SetActive(false);

        // desativa a mochila (só agora!)
        if (MochilaCenario != null)
            MochilaCenario.SetActive(false);
    }
}
