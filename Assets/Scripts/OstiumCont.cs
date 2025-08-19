using UnityEngine;

public class OstiumCont : MonoBehaviour
{
    [SerializeField] private LuxOstium LuxOstium;
    public KeyCode AbrirPor = KeyCode.LeftControl;
    [SerializeField] private Electrica Força;
    private void OnMouseDown()
    {
        LuxOstium.IsOpen = !LuxOstium.IsOpen;
        // LuxOstium.GetComponent<AudioSource>().Dorta();
        if (LuxOstium.IsOpen)
        {
            Força.SisIn += 1;
            return
            }
        Força.SisIn -= 1;
    }
    void Update()
    {
        if (Input.GetKeyDown(AbrirPor))
        {
            LuxOstium.IsOpen = !LuxOstium.IsOpen;
            // LuxOstium.GetComponent<AudioSource>().Dorta();  
            if (LuxOstium.IsOpen)
            {
                Força.SisIn += 1;
                return
            }
             Força.SisIn -= 1;
        }
    }
}

