using UnityEngine;

public class LuxCont : MonoBehaviour
{
    [SerializeField] private LuxOstium LuxOstium;
    public KeyCode LigarLux = KeyCode.LeftControl;

    private void OnMouseDown()
    {
        LuxOstium.MutareLux();
    }

    void Update()
    {
        if (Input.GetKeyDown(LigarLux))
        {
            LuxOstium.MutareLux();
        }
    }
}
