using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    [Header("Custom Noitada")]
    [SerializeField] private GameObject CNUI;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void Iniciar()
    {
        SceneManager.LoadScene(1);
    }
    public void Sair()
    {
        Application.Quit();
    }

    public void Voltar()
    {
        SceneManager.LoadScene(0);
    }

    public void MostrarCN()
    {
        CNUI.SetActive(true);
    }

    public void EsconderCN()
    {
        CNUI.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
