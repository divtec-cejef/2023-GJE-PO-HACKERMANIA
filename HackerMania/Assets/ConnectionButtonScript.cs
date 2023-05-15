using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ConnectionButtonScript : MonoBehaviour
{
    private PasswordController passwordcontroller;
    public string sceneName;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(passwordcontroller.isPasswordCorrect == true)
        {
            // Charge la nouvelle sc�ne
        SceneManager.LoadScene(sceneName);
        }
    }
}
