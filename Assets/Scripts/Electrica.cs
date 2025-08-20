using UnityEngine;

public class Electrica : MonoBehaviour
{
    public int SisIn;

    [SerializeField] private double Força = 100;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (SisIn == 1)
        {
            Força -= 0.1 * Time.deltaTime;
        }
        else
        {
            Força -= (SisIn) / 2 * Time.deltaTime;
        }
    }
}
