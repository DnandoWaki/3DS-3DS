using UnityEngine;

public class AnimeSis : MonoBehaviour
{

    [SerializeField] private NavMeshAgent NMA;

    [SerializeField] private GameObject[] Alvo;

    [SerializeField] private int AlvoAtual;

    void Start()
    {
        NMA = GetComponent<NavMeshAgent>();
    }
    void update()
    { 
        if(vector3.distance(transform.position, Alvo[AlvoAtual].transform.position) <= 0,5f)
            {
            AlvoAtual += 1;
            if (AlvoAtual >= Alvo.length)
                {
                AlvoAtual = 0;
                }
            }
    NMA.destination = Alvo[AlvoAtual].transform.position;
    }
}
