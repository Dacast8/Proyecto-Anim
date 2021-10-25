using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Botones : MonoBehaviour
{
    private Button act;
    public int contador=0;
    
    private string Puntos = "puntos";
    // Start is called before the first frame update

    private void Awake()
    {
        act = GameObject.FindGameObjectWithTag("Archivos").GetComponent<Button>();
        //act.enabled = false;
        LoadData();
        
        
    }

    void Start()
    {

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

        }

        else if (contador >= 1)
        {
            act.enabled = true;

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
        Application.Quit();

    }
}
