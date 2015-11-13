using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MenuScript : MonoBehaviour {


    /**
        public global variables for the quit menu canvas.
    */

    public Canvas quitMenu, gamemode;
    public Button startText;
    public Button exitText;
	public Button singlePlayer , multiplayer;

	// Use this for initialization
	void Start () {

        // get all UI component inside the (quitMenu canvas)
        quitMenu = quitMenu.GetComponent<Canvas>();
		gamemode = gamemode.GetComponent<Canvas>();
        quitMenu.enabled = false;
		gamemode.enabled = false;

        startText = startText.GetComponent<Button>();
        exitText = startText.GetComponent<Button>();

		singlePlayer = startText.GetComponent<Button>();
		multiplayer = startText.GetComponent<Button>();




    }
	
	// Update is called once per frame
	void Update () {
	
	}


    public void ExitPress() {

        quitMenu.enabled = true;
        startText.enabled = false;
        exitText.enabled = false;

    }


    public void NoPress(){

        quitMenu.enabled = false;
        startText.enabled = true;
        exitText.enabled = true;

    }

	public void PlayPress(){
		gamemode.enabled = true;
		startText.enabled = false;
		exitText.enabled = false;
	}

	public void SinglePlayerPress(){
		gamemode.enabled = false;
		startText.enabled = true;
		exitText.enabled = true;
	}

   

	public void StartGame() {

        Application.LoadLevel(1);
    }


    public void ExitGame() {

        Application.Quit();

    }




}
