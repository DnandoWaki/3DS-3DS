using UnityEngine;

public class OstiumCont : MonoBehaviour
{
    [SerializeField] private LuxOstium LuxOstium;
    public KeyCode AbrirPor = KeyCode.LeftControl;
    [SerializeField] private Electrica Forca;
    private void OnMouseDown()
    {
        LuxOstium.IsOpen = !LuxOstium.IsOpen;
        // LuxOstium.GetComponent<AudioSource>().Dorta();
        if (LuxOstium.IsOpen)
        {
            Forca.SisIn -= 1;
            return;
            }
        Forca.SisIn += 1;
    }
    void Update()
    {
        if (Input.GetKeyDown(AbrirPor))
        {
            LuxOstium.IsOpen = !LuxOstium.IsOpen;
            // LuxOstium.GetComponent<AudioSource>().Dorta();  
            if (LuxOstium.IsOpen)
            {
                Forca.SisIn -= 1;
                return;
            }
             Forca.SisIn += 1;
        }
    }
}

