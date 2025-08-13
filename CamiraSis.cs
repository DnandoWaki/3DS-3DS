using UnityEngine;

public class CamiraSis : MonoBehaviour
{
    [SerializeField] private GameObject[] Came;
    [SerializeField] private int AtualCame;
    [SerializeField] public Keycode AbrirCame;
    [SerializeField] private bool CameAbert;

    void start()
    {
        Came[AtualCame].SetActive(false);
    }

    void update()
    {
        if (Input.SetKeyDown(AbrirCame))
        {
            CameAbert = !CameAbert;
            ShowCame():
        }

        if
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
