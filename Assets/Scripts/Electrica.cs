using UnityEngine;
using TMPro;

public class Electrica : MonoBehaviour
{
    public int SisIn;
    //Força
    public float Forca = 100;

    [SerializeField] private TextMeshProUGUI EnergiaText;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (SisIn == 1)
        {
            Forca -= 0.1f * Time.deltaTime;
        }
        else
        {
            Forca -= (SisIn) / 2f * Time.deltaTime;
        }

        var forca = string.Format("{0:0}", Forca);
        EnergiaText.text = $"{forca}%";
    }
}
