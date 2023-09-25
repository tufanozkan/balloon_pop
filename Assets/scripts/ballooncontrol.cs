using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballooncontrol : MonoBehaviour
{
    public GameObject bomm;
    gamecontrol gameControlScript;

    private void Start()
    {
        gameControlScript = GameObject.Find("_scripts").GetComponent<gamecontrol> ();
    }

    private void OnMouseDown()
    {
        GameObject go = Instantiate(bomm, transform.position, transform.rotation) as GameObject;
        Destroy(this.gameObject);
        Destroy(go, 0.333f);
        gameControlScript.BalonEkle();
    }
}
