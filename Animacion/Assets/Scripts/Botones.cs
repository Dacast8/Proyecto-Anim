using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Botones : MonoBehaviour
{
    private Button act;
    private Canvas act2;
    //private Image act2i;
    public int contador=0;
    
    private string Puntos = "puntos";
    // Start is called before the first frame update

    private void Awake()
    {
        act = GameObject.FindGameObjectWithTag("Archivos").GetComponent<Button>();
        act2 = GameObject.FindGameObjectWithTag("Feedback").GetComponent<Canvas>();
        //act2i = GameObject.FindGameObjectWithTag("Feedback").GetComponent<Image>();
        //act.enabled = false;
        LoadData();
        
        
    }

    void Start()
    {
        act2.enabled = true;
        Verificar();


    }

    // Update is called once per frame
    void Update()
    {
       // Verificar();



    }
    

    public void ActivarBoton()
    {
        contador++;
        Debug.Log(contador);
        
        
        // act.enabled = true;

    }
    private void Verificar()
    {
        if (contador == 0)
        {
            act.enabled = false;
            
            //act2i.enabled = true;

        }

        else if (contador >= 1)
        {
            act.enabled = true;
            act2.enabled = false;
            //act2i.enabled = false;

       }
    }

    private void OnDestroy()
    {
        SaveData();

    }

    private void SaveData()
    {
        PlayerPrefs.SetInt(Puntos, contador);
        

    }
    private void LoadData()
    {
        contador = PlayerPrefs.GetInt(Puntos, 0);
       
    }

    public void BorrarDatos()
    {
        PlayerPrefs.DeleteKey("puntos");
        contador = 0;
        

    }

    public void SalirApp()
    {
        Application.Quit();

    }
}
