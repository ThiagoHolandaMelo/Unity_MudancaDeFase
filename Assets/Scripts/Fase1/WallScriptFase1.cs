using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WallScriptFase1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Iniciou WALL");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay(Collider outher)
    {
        string cenaAtual = SceneManager.GetActiveScene().name;

        if (outher.tag == "Player")
        {
            if( cenaAtual == "Fase 1")
            {
                SceneManager.LoadScene("Fase 2", LoadSceneMode.Single);
            }
            else
            {
                SceneManager.LoadScene("Fase 1", LoadSceneMode.Single);
            }

            
        }
    }


}
