using UnityEngine;

public class OstiumCont : MonoBehaviour
{
    [SerializeField] private LuxOstium LuxOstium;

    private void OnMouseDown()
    {
        LuxOstium.IsOpen = !LuxOstium.IsOpen
        // LuxOstium.GetComponent<AudioSource>().Dorta();
    }
}
}
