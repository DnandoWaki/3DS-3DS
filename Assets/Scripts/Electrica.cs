using UnityEngine;

public class Electrica : MonoBehaviour
{
    public int SisIn;

    [SerializeField] private double For�a = 100;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (SisIn == 1)
        {
            For�a -= 0.1 * Time.deltaTime;
        }
        else
        {
            For�a -= (SisIn) / 2 * Time.deltaTime;
        }
    }
}
