using UnityEngine;

public class Electrica : MonoBehaviour
{
    public int SisIn;
    //Força
    [SerializeField] private double Forca = 100;

    [SerializeField] private TextMeshProGUI EnergiaText;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (SisIn == 1)
        {
            Forca -= 0.1 * Time.deltaTime;
        }
        else
        {
            Forca -= (SisIn) / 2 * Time.deltaTime;
        }

        var forca = string.Format("{0:0}", Forca);
        EnergiaText.text = $"{forca}%";
    }
}
