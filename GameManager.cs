using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

    public GameObject bob, bobby;
    public Image currentChr;
    public Sprite[] spt;

    bool gecis;

	void Update () {
        if (Input.GetKeyDown(KeyCode.Tab))
            gecis = !gecis;

        if (gecis)
        {
            bob.SetActive(true);
            bobby.SetActive(false);
            currentChr.sprite = spt[0];
        }else
        {
            bob.SetActive(false);
            bobby.SetActive(true);
            currentChr.sprite = spt[1];
        }
	}
}
