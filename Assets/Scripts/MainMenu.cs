using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour {

	public GUISkin testSkin;

	void Start(){
		float textSize = Screen.height * 0.04f;
		testSkin.button.fontSize = (int)textSize;
	}

	void OnGUI(){
		GUI.skin = testSkin;
		if(GUI.Button (new Rect ((Screen.width/2)-(Screen.width*0.1f),((Screen.height/2)-(Screen.height*0.05f))-(Screen.height/17),Screen.width*0.2f,Screen.height*0.1f),"Play")) {
			Application.LoadLevel("beforecameraedit");
			}
		if(GUI.Button (new Rect ((Screen.width/2)-(Screen.width*0.1f),((Screen.height/2)-(Screen.height*0.05f))+(Screen.height/17),Screen.width*0.2f,Screen.height*0.1f),"Quit")){
			Application.Quit();
			}
		}
}
