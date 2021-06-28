using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MudarCena : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Menu(){
        SceneManager.LoadScene("Menu", LoadSceneMode.Single);
    }
    public void Instrucoes(){
        SceneManager.LoadScene("Instrucoes", LoadSceneMode.Single);
    }
    public void Creditos(){
        SceneManager.LoadScene("Creditos", LoadSceneMode.Single);
    }
}
