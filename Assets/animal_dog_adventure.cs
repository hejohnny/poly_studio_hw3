using UnityEngine;
using System.Collections;

public class animal_dog_adventure : MonoBehaviour {

	string currentRoom = "Bedroom";

	// Use this for initialization
	void Start () {
		Debug.Log ( "Hello World!" );
	}
	
	// Update is called once per frame
	void Update () {

		string textBuffer = "TEXT ADVENTURE: You are in the " + currentRoom;
		
		if ( currentRoom == "Bedroom" )
		{

			textBuffer += "\nThe dog is sitting quietly in the corner.";
			textBuffer += "\nPress [W] to go to the Dining Room.";
			
			if ( Input.GetKeyDown (KeyCode.W) )
			{
				currentRoom = "Dining Room";
			}

		}
		else if( currentRoom == "Dining Room")
		{
			textBuffer += "\nYour food bowl is here, there is currently no food in it.";
			textBuffer += "\nPress [W] to go to the Kitchen.";
			if ( Input.GetKeyDown (KeyCode.W) )
			{
				currentRoom = "Kitchen";
			}
		}
		else if ( currentRoom == "Kitchen" )
		{
			textBuffer += "\nThere are cookies on the table, You eat a cookie.";
			textBuffer += "\nPress [W] to go to Living Room.";
			if ( Input.GetKeyDown (KeyCode.W) )
			{
				currentRoom = "Living Room";
			}
		}
		else if (currentRoom == "Living Room")
		{
			textBuffer += "\nThe couch looks comfortable, You take a nap.";
			textBuffer += "\nPress [W] to go to the Garden.";
			if ( Input.GetKeyDown (KeyCode.W) )
			{
				currentRoom = "Garden";
			}

		}
		else if(currentRoom == "Garden")
		{
			textBuffer += "\nThe newly planted flowers get your attention, You walk over and take a sniff.";
			textBuffer += "\nPress [W] to go to the Front Lawn.";
			if ( Input.GetKeyDown (KeyCode.W) )
			{
				currentRoom = "Front Lawn";
			}
		}
		else if(currentRoom == "Front Lawn")
		{
			textBuffer += "\nYour favorite ball is on the grass, You run over to it.";
		}

		// overwrite contents of "text" variable on the TextMesh component with contents of textBuffer variable
		GetComponent<TextMesh>().text = textBuffer;
	}
}
