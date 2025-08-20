using UnityEngine;

public class AnimeSis : MonoBehaviour
{

    [SerializeField] private UnityEngine.AI.NavMeshAgent NMA;

    [SerializeField] private GameObject[] Alvo;

    [SerializeField] private int AlvoAtual;

    void Start()
    {
        NMA = GetComponent<UnityEngine.AI.NavMeshAgent>();
    }
    void Update()
    { 
        if(Vector3.Angle(transform.position, Alvo[AlvoAtual].transform.position) <= 0.5f)
            {
            AlvoAtual += 1;
            if (AlvoAtual == 0)
                {
                AlvoAtual = 0;
                }
            }
    NMA.destination = Alvo[AlvoAtual].transform.position;
    }
}
