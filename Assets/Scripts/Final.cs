using UnityEngine;
using System.Collections;

public class Final : MonoBehaviour {
	
	public GUISkin finalSKin;
	

	void OnGUI(){
		GUI.skin = finalSKin;
		if(GUI.Button (new Rect ((Screen.width/2)-(Screen.width*0.1f),((Screen.height/2)-(Screen.height*0.05f)+175),Screen.width*0.2f,Screen.height*0.1f),"Main menu")) {
			Application.LoadLevel(0);
		}
		if(GUI.Button (new Rect ((Screen.width/2)-(Screen.width*0.1f),((Screen.height/2)-(Screen.height*0.05f)+250),Screen.width*0.2f,Screen.height*0.1f),"Quit")){
			Application.Quit();
		}
	}
}
