using UnityEngine;
using UnityEngine.UI;

public class Scoring : MonoBehaviour
{

    public string scoree;

    // public int hiscore;

    public Text t;



    public void Start()
    {
        //hiscore = MathController.staticScore;
        int newscore = PlayerPrefs.GetInt("score");
        t.text = newscore.ToString();

    }
}
