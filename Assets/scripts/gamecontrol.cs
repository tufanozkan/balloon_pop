using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class gamecontrol : MonoBehaviour
{
    public TextMeshProUGUI timetext, balloontext, gameover;
    public GameObject bomm;
    public float timecount = 60;
    int bcount = 0;
    // Start is called before the first frame update
    void Start()
    {
        balloontext.text = "BALLOON:" + bcount;
    }

    // Update is called once per frame
    void Update()
    {
        if (timecount > 0)
        {
            timecount -= Time.deltaTime;
            timetext.text = "TIME:" + (int)timecount;
        }
        else
        {
            GameObject[] go = GameObject.FindGameObjectsWithTag("b");
            for (int i = 0; i<go.Length; i++)
            {
                Instantiate(bomm, go[i].transform.position, go[i].transform.rotation);
                gameover.text = "GAME \n OVER!";
                Destroy(go[i]);
            }
        }
    }

    public void BalonEkle()
    {
        bcount += 1;
        balloontext.text = "BALLOON: " + bcount;
    }
}
