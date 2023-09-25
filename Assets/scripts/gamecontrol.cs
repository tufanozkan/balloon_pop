using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class gamecontrol : MonoBehaviour
{
    public TextMeshProUGUI timetext, balloontext;
    float timecount = 60;
    int bcount = 0;
    // Start is called before the first frame update
    void Start()
    {
        balloontext.text = "BALLOON:" + bcount;
    }

    // Update is called once per frame
    void Update()
    {
        timecount -= Time.deltaTime;
        timetext.text = "TIME:" + (int)timecount;
    }

    public void BalonEkle()
    {
        bcount += 1;
        balloontext.text = "BALLOON: " + bcount;
    }
}
