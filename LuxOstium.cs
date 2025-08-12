using UnityEngine;

public class LuxOstium : MonoBehaviour
{
    [SerializeField] private GameObject Lux;

    [SerializeField] private Vector3 OpenOs;
    [SerializeField] private Vector3 CloseOs;

    [SerializeField] private float FechaVelo;

    public boot IsOpen;
    public boot In;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        transform.position = OpenOs;
        IsOpen = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (IsOpen)
        {
            if (transform.position != OpenOs)
            {

                if (Vector3.Distance(transform.position, OpenOs) <= 0.5f)
                {
                    transform.position = OpenOs;
                }
                else
                {
                    transform.position = Vector3.Lerp(transform.position, OpenOs, FechaVelo * Time.deltaTime);
                }
            }
        }
        else {
            if (transform.position != CloseOs)
            {

                if (Vector3.Distance(transform.position, CloseOs) <= 0.5f)
                {
                    transform.position = CloseOs;
                }
                else
                {
                    transform.position = Vector3.Lerp(transform.position, CloseOs, FechaVelo * Time.deltaTime);
                }
            }
        }
        
    }

    public void MutareLux()
    {
        In = !In;

        if (In) {
            Lux.SetActive(true);
        }
        else
        {
            Lux.SetActive(false);
        }
    }
