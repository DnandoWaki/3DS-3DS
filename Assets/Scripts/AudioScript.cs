using UnityEngine;

public class AudioScript : MonoBehaviour
{
    private int MKLevel;
    [SerializeField] public AudioSource A;
    [SerializeField] public AudioSource B;
    [SerializeField] public AudioSource C;
    [SerializeField] public AudioSource D;
    [SerializeField] private bool isCN;
    [SerializeField] private string Chave;
    [SerializeField] private AnimeSis MKTimer;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (isCN)
        {
            MKLevel = PlayerPrefs.GetInt(Chave, 0);
        }
    }

    // Update is called once per frame
    void Update()
    {if (MKTimer <= 0) 
       { 
        if (MKLevel >= 1 && MKLevel <=5) 
        { 
           A.Play();
        }
        else if (MKLevel >= 6 && MKLevel <= 10)
        {
            B.Play();
        }
        else if (MKLevel >= 11 && MKLevel <= 15)
        {
            C.Play();
        }
        else if (MKLevel >= 16 && MKLevel <= 20)
        {
            D.Play();
        }
            return;
       }
        A.Pause();
        B.Pause();
        C.Pause();
        D.Pause();

    }
}
