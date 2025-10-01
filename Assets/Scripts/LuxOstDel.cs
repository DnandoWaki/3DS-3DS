using UnityEngine;

public class LuxOstDel : MonoBehaviour
{
    [SerializeField] private Electrica Forca;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void ZeroGasto(GameObject Dortas)
    { if (Forca.Forca <= 0) { 
        Destroy(Dortas); 
        }
    }
}
