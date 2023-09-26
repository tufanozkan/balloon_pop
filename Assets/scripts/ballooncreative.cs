using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballooncreative : MonoBehaviour
{
    public GameObject balloon;
    float balloontime = 1f;
    float timecount = 0f;
    gamecontrol gameC;

    // Start is called before the first frame update
    void Start()
    {
        gameC = this.gameObject.GetComponent<gamecontrol>();
    }

    // Update is called once per frame
    void Update()
    {
        timecount -= Time.deltaTime;
        if (timecount < 0 && gameC.timecount > 0)
        {
            GameObject go = Instantiate(balloon,new Vector3(Random.Range(-2.35f,2.35f), -5.88f, 0), Quaternion.Euler(0, 0, 0)) as GameObject;
            go.GetComponent<Rigidbody2D>().AddForce(new Vector3(0,Random.Range(40f,90f), 0));
            timecount = balloontime;
        }
        
    }
}
