using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class prueba : MonoBehaviour
{
    private Canvas activado;
    public int archivoscontador = 0;

    private string Archivos = "archivos";
    // Start is called before the first frame update

    private void Awake()
    {
        activado = GameObject.FindGameObjectWithTag("culpable").GetComponent<Canvas>();
        //act.enabled = false;
        LoadData();
        

    }

    void Start()
    {

        //Verificar();


    }

    // Update is called once per frame
    void Update()
    {
         Verificar();



    }


    public void SumarArchivos()
    {
        archivoscontador++;
        Debug.Log(archivoscontador);


        

    }
    private void Verificar()
    {
        if (archivoscontador < 3)
        {
            activado.enabled = false;

        }

        else if (archivoscontador >= 3)
        {
            activado.enabled = true;

        }
    }

    private void OnDestroy()
    {
        SaveData();

    }

    private void SaveData()
    {
        PlayerPrefs.SetInt(Archivos, archivoscontador);


    }
    private void LoadData()
    {
        archivoscontador = PlayerPrefs.GetInt(Archivos, 0);

    }

    public void BorrarDatos()
    {
        PlayerPrefs.DeleteKey("archivos");
        archivoscontador = 0;
        //Application.Quit();

    }
}
