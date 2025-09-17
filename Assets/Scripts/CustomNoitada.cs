using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class CustomNoitada : MonoBehaviour
{
    [SerializeField] private int[] LevelAgress;
    [SerializeField] private TextMeshProUGUI[] LevelAgressAmostra;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void AumentAgress(int AnimeId)
    {
        var AtualAgress = LevelAgress[AnimeId];
        AtualAgress++;

        if (AtualAgress > 20)
        {
            AtualAgress = 0;
        }

        LevelAgress[AnimeId] = AtualAgress;
        LevelAgressAmostra[AnimeId].text = AtualAgress.ToString();
    }

    public void DiminuAgress(int AnimeId)
    {
        var AtualAgress = LevelAgress[AnimeId];
        AtualAgress--;

        if (AtualAgress < 0)
        {
            AtualAgress = 20;
        }

        LevelAgress[AnimeId] = AtualAgress;
        LevelAgressAmostra[AnimeId].text = AtualAgress.ToString();
    }

    public void ComeçarJogo()
    {

    }
}