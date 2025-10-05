using UnityEngine;
using UnityEngine.SceneManagement;

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

    [SerializeField] private int LevelAnime = 3;

    [SerializeField] private bool isCN;
    [SerializeField] private string Chave;

    void Start()
    {
        NMA = GetComponent<UnityEngine.AI.NavMeshAgent>();

        if (isCN)
        {
            LevelAnime = PlayerPrefs.GetInt(Chave, 0);
        }
    }
    void Update()
    {
        if (ResfriaTimer <= 0)
        {
            var chanceCheck = Random.Range(ChanceMinMove, ChanceMaxMove);

            if(chanceCheck <= LevelAnime)
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
                        Debug.Log("Morreu");
                        SceneManager.LoadScene(2);
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
    NMA.destination = Alvo[AlvoAtual].transform.position;
    }

    public void RestartCena()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
