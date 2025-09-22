using UnityEngine;

public class OstiumCont : MonoBehaviour
{
    [SerializeField] private LuxOstium Ostium;
    public KeyCode AbrirPor = KeyCode.LeftControl;
    [SerializeField] private Electrica Forca;
    private void OnMouseDown()
    {
        if (Forca.Forca <= 0)
        {
            return;
        }
        Ostium.IsOpen = !Ostium.IsOpen;
        Ostium.GetComponent<AudioSource>().Play();
        if (Ostium.IsOpen)
        {
            Forca.SisIn -= 1;
            return;
            }
        Forca.SisIn += 1;
    }
    void Update()
    {
        if (Forca.Forca <= 0)
        {
            return;
        }
        if (Input.GetKeyDown(AbrirPor))
        {
            Ostium.IsOpen = !Ostium.IsOpen;
            Ostium.GetComponent<AudioSource>().Play();  
            if (Ostium.IsOpen)
            {
                Forca.SisIn -= 1;
                return;
            }
             Forca.SisIn += 1;
        }
    }
}

