using UnityEngine;

public class LuxOstium : MonoBehaviour
{
    [SerializeField] private GameObject Lux;

    [SerializeField] private Vector3 OpenOs;
    [SerializeField] private Vector3 CloseOs;

    [SerializeField] private float FechaVelo;

    public bool IsOpen;
    public bool In;

    [SerializeField] private Electrica Forca;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        transform.position = OpenOs;
        IsOpen = true;

        MutareLux();
    }

    // Update is called once per frame
    void Update()
    {
        if (Forca.Forca >= 0)
        {
            return;
        }
        if (IsOpen)
        {
            if (transform.position != OpenOs)
            {

                if (Vector3.Distance(transform.position, OpenOs) <= 0.5f)
                {
                    transform.position = OpenOs;
                    return;
                }
                transform.position = Vector3.Lerp(transform.position, OpenOs, FechaVelo * Time.deltaTime);
            }
            return;
        }
        if (transform.position != CloseOs)
        {

            if (Vector3.Distance(transform.position, CloseOs) <= 0.5f)
            {
                transform.position = CloseOs;
                return;
            }
            transform.position = Vector3.Lerp(transform.position, CloseOs, FechaVelo * Time.deltaTime);
        }

    }

    public void MutareLux()
    {
        In = !In;

        if (In)
        {
            Lux.SetActive(true);
            Forca.SisIn += 1;
            return;
        }
        Lux.SetActive(false);
        Forca.SisIn -= 1;
    }
}
