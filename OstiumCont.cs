using UnityEngine;

public class OstiumCont : MonoBehaviour
{
    [SerializeField] private LuxOstium LuxOstium;
    public KeyCode AbrirPor = KeyCode.LeftControl;

    private void OnMouseDown()
    {
        LuxOstium.IsOpen = !LuxOstium.IsOpen
        // LuxOstium.GetComponent<AudioSource>().Dorta();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode))
        {
            LuxOstium.IsOpen = !LuxOstium.IsOpen
        // LuxOstium.GetComponent<AudioSource>().Dorta();  
        }
    }
}

