using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DialogueTrigger : MonoBehaviour
{
    [TextArea]
    public string dialogueText; // texto aparece, se pa
    public GameObject dialogueUI; // painel
    public TMP_Text dialogueUIText;   // texto

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            dialogueUI.SetActive(true);
            dialogueUIText.text = dialogueText;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            dialogueUI.SetActive(false);
        }
    }
}
