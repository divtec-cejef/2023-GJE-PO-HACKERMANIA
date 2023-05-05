using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class GameOver : MonoBehaviour
{
public bool Catch = false;
public static GameOver instance;

private void Awake(){
    if (instance == null){
        Debug.LogWarning("Il y a plus d'une instance de GameOver dans la sc�ne");
        return
    }
    instance = this;
}

    // Start is called before the first frame update
    void Start(){
        
    }

    //Fonction qui s'execute lorsque le joueur se fait rep�rer et attraper par le garde
    public void GetCatch (){
        Catch = True;
        GameOver();
        return;
    }

    //Fonction qui s'execute lorsque le joueur se fait attraper par le garde
    public void GameOver(){
		if (Catch == True){
            PlayerMovement.instance.enable = true;
            PlayerMovement.instance.animator.SetTrigger("Die");
            SceneManagement.LoadScene("GameOver");
			Debug.Log("GameOver");
			return;
		}
	}

    // Update is called once per frame
    void Update(){
        
    }
}
