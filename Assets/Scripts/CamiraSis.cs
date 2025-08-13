using UnityEngine;

public class CamiraSis : MonoBehaviour
{
    [SerializeField] private GameObject[] Came;
    [SerializeField] private int AtualCame;
    [SerializeField] public KeyCode AbrirCame;
    [SerializeField] private bool CameAbert;

    void Start()
    {
        Came[AtualCame].SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown(AbrirCame))
        {
            CameAbert = !CameAbert;
            ShowCame();
        }

        if(Input.GetKeyUp(AbrirCame))
        {

        }
    }

    private void ShowCame()
    {
        if (CameAbert)
        {
            Came[AtualCame].SetActive(true);
            return;
        }
        Came[AtualCame].SetActive(false);
    }

    private void VaiPaCame(int Progession)
    {

    }
}
