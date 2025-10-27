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
    [SerializeField] private AnimeSis AniLVL;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (isCN)
        {
            MKLevel = PlayerPrefs.GetInt(Chave, 0);
        }
        else
        {
            MKLevel = AniLVL.LevelAnime;
        }
    }

    // Update is called once per frame
    void Update()
    {
       if (MKTimer.MikaelTimer >= 0) 
       { 
            if (MKLevel >= 1 && MKLevel <=5) 
            { 
               A.playOnAwake = true;
            }
            else if (MKLevel >= 6 && MKLevel <= 10)
            {
                B.playOnAwake = true;
            }
            else if (MKLevel >= 11 && MKLevel <= 15)
            {
                C.playOnAwake = true;
            }
            else if (MKLevel >= 16 && MKLevel <= 20)
            {
                D.playOnAwake = true;
            }
                return;
       }
        A.playOnAwake = false;
        B.playOnAwake = false;
        C.playOnAwake = false;
        D.playOnAwake = false;

    }
}
