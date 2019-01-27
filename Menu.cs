using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour {

    public GameObject menuPanel, hazirlayanlar;

    public void hazirlayanlarAc ( )
    {
        hazirlayanlar.SetActive(true);
        menuPanel.SetActive(false);
    }

    public void menuyeDon ()
    {
        hazirlayanlar.SetActive(false);
        menuPanel.SetActive(true);
    }

    public void JenerigiGec ()
    {
        SceneManager.LoadScene("SampleScene");
    }

	public void PlayButton ()
    {
        SceneManager.LoadScene("Jenerik");
    }

    public void exitButton ()
    {
        Application.Quit();
    }

}
