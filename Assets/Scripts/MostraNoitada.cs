using UnityEngine;
using TMPro;

public class MostraNoitada : MonoBehaviour
{
    [SerializeField] private string NomeNoitada;
    [SerializeField] private TextMeshProUGUI TextoNoitada;

    [SerializeField] private float DeleteTempo;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        TextoNoitada.text = NomeNoitada;
        Destroy(gameObject, DeleteTempo);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
