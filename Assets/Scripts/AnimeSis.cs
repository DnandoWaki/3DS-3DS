using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class AnimeSis : MonoBehaviour
{

    [SerializeField] private UnityEngine.AI.NavMeshAgent NMA;

    [SerializeField] private GameObject[] Alvo;

    [SerializeField] private int AlvoAtual;

    [SerializeField] private float ResfriaTimer;
    [SerializeField] private float MinResfriaTempo;
    [SerializeField] private float MaxResfriaTempo;

    [SerializeField] private int ChanceMinMove = 1;
    [SerializeField] private int ChanceMaxMove = 20;

    [SerializeField] public int LevelAnime = 3;

    [SerializeField] private bool Teleporta;

    [SerializeField] private bool isCN;
    [SerializeField] private string Chave;

    enum AnimeTipo {Usual, Tavares, Mikael, TavaresAF}

    [SerializeField] private AnimeTipo Tipo;

    [SerializeField] private bool Apareceu;

    [SerializeField] private float TemporMata;
    [SerializeField] private float TempoMatar;

    [SerializeField] public float MikaelTimer = 20f;
    [SerializeField] private float MikaelTime = 20f;

    [SerializeField] private GameObject JBL;
    [SerializeField] private bool MKFury;
    [SerializeField] private GameObject JS;
    [SerializeField] private Camira Camira;

    void Start()
    {
        NMA = GetComponent<UnityEngine.AI.NavMeshAgent>();
        if (Teleporta)
        {
            NMA.enabled = false;
        }
        if (isCN)
        {
            LevelAnime = PlayerPrefs.GetInt(Chave, 0);
        }
    }
    void Update()
    {
        if (Tipo == AnimeTipo.Usual)
        {
            if (ResfriaTimer <= 0)
            {
                var chanceCheck = Random.Range(ChanceMinMove, ChanceMaxMove);

                if (chanceCheck <= LevelAnime)
                {
                    if (Vector3.Distance(transform.position, Alvo[AlvoAtual].transform.position) <= 0.5f)
                    {
                        if (Alvo[AlvoAtual].GetComponent<AnimeMov>().LaPuerta)
                        {
                            if (Alvo[AlvoAtual].GetComponent<AnimeMov>().Puerta.IsOpen)
                            {
                                AlvoAtual = Alvo.Length - 1;
                            }
                            else
                            {
                                AlvoAtual = 1;
                            }
                        }
                        else if (Alvo[AlvoAtual].GetComponent<AnimeMov>().TheOffice)
                        {
                            PulaSusto();
                            Invoke("AnimeMatar", 1f);
                        }
                        else
                        {
                            AlvoAtual += 1;
                            if (AlvoAtual >= Alvo.Length)
                            {
                                AlvoAtual = 0;
                            }
                        }
                    }
                }

                var ResfriaTempo = Random.Range(MinResfriaTempo, MaxResfriaTempo);
                ResfriaTimer = ResfriaTempo;
            }
            else
            {
                ResfriaTimer -= Time.deltaTime;
            }
            if (Teleporta)
            {
                transform.position = Alvo[AlvoAtual].transform.position;
                return;
            }
            NMA.destination = Alvo[AlvoAtual].transform.position;
        }
        else if (Tipo == AnimeTipo.Tavares)
        {
            if (Apareceu)
            {
                TemporMata -= Time.deltaTime;
            }
            if (TemporMata <= 0)
            {
                PulaSusto();
                Invoke("AnimeMatar", 1f);
            }
        }
        else if (Tipo == AnimeTipo.TavaresAF)
        {
            if (Apareceu)
            {
                TemporMata -= Time.deltaTime;
            }
            if (TemporMata <= 0)
            {
                PulaSusto();
                Invoke("AnimeMatar", 1f);
            }
        }
        else if (Tipo == AnimeTipo.Mikael)
        {
            if (LevelAnime != 0)
            {
                MikaelTimer -= Time.deltaTime;
                JBL.GetComponent<Image>().fillAmount = MikaelTimer / MikaelTime;
                if (MikaelTimer <= 0)
                {
                    transform.position = Alvo[0].transform.position;
                    MKFury = true;
                    PulaSusto();
                    Invoke("AnimeMatar", 1f);
                }
            }
            else 
            {
                Object.Destroy(JBL);
            }
        }

    }
    public void CameraLigada()
    {
        if (Tipo == AnimeTipo.Tavares)
        {
            if(Apareceu) 
            { 
                Apareceu = false;
                transform.position = transform.position + new Vector3(0, -100, 0);
                return; 
            }
            int ChanceT = Random.Range(0, 1000);
            if (ChanceT == 0)
            {
                transform.position = Alvo[0].transform.position;
                TemporMata = TempoMatar;
                Apareceu = true;
            }
        }
        if (Tipo == AnimeTipo.TavaresAF)
        {
            if (Apareceu)
            {
                Apareceu = false;
                transform.position = transform.position + new Vector3(0, -100, 0);
                return;
            }
            int ChanceT = Random.Range(0, 1000000);
            if (ChanceT == 0)
            {
                transform.position = Alvo[0].transform.position;
                TemporMata = TempoMatar;
                Apareceu = true;
            }
        }
    }
    public void RestartCena()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void TocarMusica()
    {
        MikaelTimer += 2f;
        GetComponent<AudioSource>().Play();
        MikaelTimer = Mathf.Clamp(MikaelTimer, 0f, MikaelTime);
    }

    private void  AnimeMatar()
    {
        Debug.Log("Morreu");
        SceneManager.LoadScene(2);
    }

    public void PulaSusto()
    {
        Camira.GetComponent<AudioSource>().Play();
        JS.SetActive(true);
    }
}
