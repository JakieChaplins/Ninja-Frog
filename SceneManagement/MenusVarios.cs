using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class MenusVarios : MonoBehaviour
{
    [SerializeField] private AudioMixer audioMixer;

    private bool Paused;

    public GameObject[] MenusPausaOpciones;

    void Start()
    {
        Paused = false;
        MenusPausaOpciones[0].SetActive(false);
        MenusPausaOpciones[1].SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (Paused == false)
            {
                MenusPausaOpciones[0].SetActive(true);
                Time.timeScale = 0;
                Paused = true;
            }
            else
            {
                    MenusPausaOpciones[0].SetActive(false);
                    MenusPausaOpciones[1].SetActive(false);
                    Time.timeScale = 1;
                    Paused = false;
            }
        }
    }

    public void Play()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        Time.timeScale = 1;
        Paused = false;
    }

   public void Exit()
    {
        Application.Quit();
    }

   public void PantallaCompleta(bool pantallaCompleta)
    {
        Screen.fullScreen = pantallaCompleta;
    }

    public void CambiarVolumen(float volumen)
    {
        audioMixer.SetFloat("Volumen", volumen);
    }

    public void ReanudarBoton()
    {
                MenusPausaOpciones[0].SetActive(false);
                MenusPausaOpciones[1].SetActive(false);
                Time.timeScale = 1;
                Paused = false;            
    }

    public void OpcionesBoton()
    {
        MenusPausaOpciones[0].SetActive(false);
        MenusPausaOpciones[1].SetActive(true);
    }

    public void VolverBoton()
    {
        MenusPausaOpciones[0].SetActive(true);
        MenusPausaOpciones[1].SetActive(false);
    }

    public void MenuBoton()
    {
        SceneManager.LoadScene(0);
    }
}
