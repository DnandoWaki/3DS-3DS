    using UnityEngine;

public class BatePonto : MonoBehaviour
{
    [SerializeField] private float Timer;

    [SerializeField] private int PontoAcaba = 6;

    [SerializeField] private string Horologium;

    [SerializeField] private float TempoMult = 2f;

    [SerializeField] private TextMeshProUGUI HoroloTexto;

    [SerializeField] private GameObject NikeScreen;

    [SerializeField] private bool Veceu;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!Veceu)
        {
            Timer += Time.deltaTime * TempoMult;

            var horas = Mathf.FloorToInt(Timer / 60);
            var minutos = Mathf.FloorToInt(Timer - horas * 60);

            if (horas == 0)
            {
                horas = 12;
            }

            DigitalClock = string.Format("{0:00}:{1:00}", horas, minutos);

            HoroloTexto.text = Horologium;

            if (horas >= PontoAcaba)
            {
                NikeScreen.SetActive(true);
                Veceu = true;
            }
        }
    }
}
