using UnityEngine;

public class LuxCont : MonoBehaviour
{
    [SerializeField] private LuxOstium LuxOstium;
    public KeyCode LigarLux = KeyCode.LeftControl;

    private void OnMouseDown()
    {
        LuxOstium.In = !LuxOstium.In;
    }

    void Update()
    {
        if (Input.GetKeyDown(LigarLux))
        {
            LuxOstium.In = !LuxOstium.In;
        }
    }
}
