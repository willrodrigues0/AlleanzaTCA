using UnityEngine;
using TMPro;

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

    private bool jogoPausado = false; // controla se o jogador pode se mover

    // Chamado ao clicar no botão de pegar
    public void PegarMochila()
    {
        if (inventarioButton != null)
            inventarioButton.SetActive(true);

        // 🔹 Pausa o jogo ANTES de desativar a mochila
        Time.timeScale = 0f;
        jogoPausado = true;

        // Mostra o painel
        if (dialogueUI != null && dialogueUIText != null)
        {
            dialogueUI.SetActive(true);
            dialogueUIText.text = dialogueText;
        }

        // Agora sim, desativa a mochila
        if (MochilaCenario != null)
            MochilaCenario.SetActive(false);
    }

    // Chamado ao clicar no botão "X"
    public void FecharDialogo()
    {
        if (dialogueUI != null)
            dialogueUI.SetActive(false);

        // 🔹 Retoma o jogo
        Time.timeScale = 1f;
        jogoPausado = false;
    }
}
