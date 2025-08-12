using UnityEngine;

public class LuxCont : MonoBehaviour
{
    [SerializeField] private LuxOstium LuxOstium;

    private void OnMouseDown()
    {
        LuxOstium.In = !LuxOstium.In
    }
}
