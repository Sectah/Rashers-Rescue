#pragma strict

function OnCollisionStay (collision : Collision) {
	if (collision.collider.tag == "Egg"){
		
		Application.LoadLevel("beforecameraedit");
			}
	
	if (collision.collider.tag == "Crispy"){
		
		Application.LoadLevel("lvl_complete");
			}
	}