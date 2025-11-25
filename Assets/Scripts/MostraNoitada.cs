using UnityEngine;
using TMPro;

public class MostraNoitada : MonoBehaviour
{
    [SerializeField] private string NomeNoitada;
    [SerializeField] private TextMeshProUGUI TextoNoitada;

    [SerializeField] private float DeleteTempo;

    [SerializeField] private GameObject[] ItensEmCena;

    [SerializeField] private float CooldownTimer;
    void Start()
    {
        for (int i = 0; i < ItensEmCena.Length; i++) 
        { 
            ItensEmCena[i].SetActive(false);
        }
        TextoNoitada.text = NomeNoitada;
        Destroy(gameObject, DeleteTempo);
        CooldownTimer=DeleteTempo;
    }

    private void OnDestroy()
    {
        for (int i = 0; i < ItensEmCena.Length; i++)
        {
            ItensEmCena[i].SetActive(true);
        }
    }
}
