using UnityEngine;

public class OstiumCont : MonoBehaviour
{
    [SerializeField] private LuxOstium Ostium;
    public KeyCode AbrirPor = KeyCode.LeftControl;
    [SerializeField] private Electrica Forca;
    private void OnMouseDown()
    {
        AlternarOstium();
    }

    void Update()
    {
        if (Input.GetKeyDown(AbrirPor))
        {
            AlternarOstium();
        }
    }

    private void AlternarOstium()
    {
        if (Forca.Forca > 0)
        {
            Ostium.IsOpen = !Ostium.IsOpen;
            Ostium.GetComponent<AudioSource>().Play();
            if (Ostium.IsOpen)
            {
                Forca.SisIn -= 1;
                return;
            }
            Forca.SisIn += 1;
            return;
        }
        else
        {
            Ostium.IsOpen = !Ostium.IsOpen;
            if (Ostium.IsOpen)
            {
                Forca.SisIn -= 1;
                return;
            }
        }

    }
}

