using UnityEngine;

public class OstiumCont : MonoBehaviour
{
    [SerializeField] private LuxOstium LuxOstium;
    public KeyCode AbrirPor = KeyCode.LeftControl;
    [SerializeField] private Electrica For�a;
    private void OnMouseDown()
    {
        LuxOstium.IsOpen = !LuxOstium.IsOpen;
        // LuxOstium.GetComponent<AudioSource>().Dorta();
        if (LuxOstium.IsOpen)
        {
            For�a.SisIn += 1;
            return
            }
        For�a.SisIn -= 1;
    }
    void Update()
    {
        if (Input.GetKeyDown(AbrirPor))
        {
            LuxOstium.IsOpen = !LuxOstium.IsOpen;
            // LuxOstium.GetComponent<AudioSource>().Dorta();  
            if (LuxOstium.IsOpen)
            {
                For�a.SisIn += 1;
                return
            }
             For�a.SisIn -= 1;
        }
    }
}

