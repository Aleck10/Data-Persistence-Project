using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

[DefaultExecutionOrder(1000)]
public class MenuUIHandler : MonoBehaviour
{

    public TMP_InputField inputField;
  


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void StartNew()
    {
        MenuManager.Instance.LoadBestScore();
        SceneManager.LoadScene(1);
    }

    public void NewNameSelected() 
    {
        string playerText = inputField.text;
        MenuManager.Instance.PlayerName = playerText;


        Debug.Log(playerText);
            
    }

    
}
   
