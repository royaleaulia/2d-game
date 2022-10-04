using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreAll : MonoBehaviour
{
    // Start is called before the first frame update
    public ScoreCounterBlue scorecounterblue;
    public ScoreCounterGreen scorecountergreen;
    public ScoreCounterRed scorecounterred;
    public ScoreCounterYellow scorecounteryellow;
    public ScoreCounterAbuAbu scorecounterabu;

    public TextMeshProUGUI countText;

    public int countall;

    void Start()
    {
        countall = 0;
    }

    void SetCountText()
    {
        countText.text = "Count: " + countall.ToString();

    }
    // Update is called once per frame


    void Update()
    {
        countall = scorecounterblue.countblue + scorecountergreen.countgreen + scorecounterred.countred + scorecounterabu.countabu + scorecounteryellow.countyellow; /*+ scorecounterabu.count*//* + scorecounteredyellow.count*/
        

        SetCountText();
        

    }
}
