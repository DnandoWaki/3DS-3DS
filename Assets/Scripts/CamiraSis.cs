using UnityEngine;

public class CamiraSis : MonoBehaviour
{
    [SerializeField] private GameObject[] Came;
    [SerializeField] private int AtualCame;
    [SerializeField] public KeyCode AbrirCame;
    [SerializeField] public KeyCode TrocaCame1;
    [SerializeField] public KeyCode TrocaCame2;
    [SerializeField] private bool CameAbert;
    [SerializeField] private GameObject MainCamera;
    [SerializeField] private float TempoRecarga;
    [SerializeField] private float RecargaTempo = 0.5f;
    [SerializeField] private GameObject CamiraSisIU;
    [SerializeField] private Electrica Forca;

    void Start()
    {
        for (int i = 0; 1 < Came.Length; i++)
        {
            Came[i].SetActive(false);
        }
        CamiraSisIU.SetActive(false);
        Came[AtualCame].SetActive(false);
    }

    void Update()
    {
        if (Forca.Forca >= 0)
        {
            CameAbert = false;
            ShowCame();
            return;
        }
        if (Input.GetKeyDown(AbrirCame))
        {
            CameAbert = !CameAbert;
            ShowCame();
        }

        if (TempoRecarga <= 0)
        {
            if (Input.GetKeyDown(TrocaCame1))
            {
                Came[AtualCame].SetActive(false);
                AtualCame = AtualCame + 1;
                if (AtualCame >= Came.Length) 
                {
                    AtualCame = 0;
                }
                VaiPaCame(AtualCame);
                TempoRecarga = RecargaTempo;
            }
            else if(Input.GetKeyDown(TrocaCame2))
            {
                Came[AtualCame].SetActive(false);
                AtualCame = AtualCame - 1;
                if (AtualCame < 0)
                {
                    AtualCame = Came.Length - 1;
                }
                VaiPaCame(AtualCame);
                TempoRecarga = RecargaTempo;
            }
            return;
        }
        TempoRecarga -= Time.deltaTime;
    }

    private void ShowCame()
    {
        if (CameAbert)
        {
            Came[AtualCame].SetActive(true);
            CamiraSisIU.SetActive(true);
            MainCamera.SetActive(false);
            return;
        }
        Came[AtualCame].SetActive(false);
        CamiraSisIU.SetActive(false);
        MainCamera.SetActive(true);
    }

    public void VaiPaCame(int Progession)
    {
        Came[AtualCame].SetActive(false);
        AtualCame = Progession;
        ShowCame();
    }
}
