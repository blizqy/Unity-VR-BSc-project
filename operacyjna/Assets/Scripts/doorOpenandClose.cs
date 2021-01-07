/*/Script made by Strups Productions/*/
using UnityEngine;
using System.Collections;

public class doorOpenandClose : MonoBehaviour {

	//Text variables
	public bool T_ActivatedOpen = true;
	public bool T_ActivatedClose = false;
	public bool activateTrigger = false;

	//Animator variables
	Animator animator;
	bool doorOpen;






	void Start () { //what happens in the beginning of the game.
		T_ActivatedOpen = true;
		T_ActivatedClose = false;

		animator = GetComponent<Animator> ();
		doorOpen = false;




	
	}
	

	void Update () { //The main function wich controlls how the system will work.

		if (T_ActivatedOpen == true)
			T_ActivatedClose = false;

		else if (T_ActivatedClose == true)
			T_ActivatedOpen = false;

		if (activateTrigger) //For some reaseon you can't have both E (open and close).
			{
				T_ActivatedOpen = false;
				T_ActivatedClose = true;
				doorOpen = true;

			if (doorOpen) 
			{
				doorOpen = true;
				doorController ("Open");
			}
				
			}
			else if(T_ActivatedClose && activateTrigger)
			{
				T_ActivatedOpen = true;
				T_ActivatedClose = false;
		
					
			if (doorOpen) 
			{
				doorOpen = false;
				doorController ("Close");
			}
				
			} 
	}


														
	void OnTriggerEnter(Collider col) //If you enter the trigger this will happen.
	{
		if(col.gameObject.tag == "Player")
		{

			activateTrigger = true;
		}
		
	}


	void OnTriggerExit(Collider col) //If you exit the trigger this will happen.
	{
		if(col.gameObject.tag == "Player")
		{
			activateTrigger = false;
		}

	}

	void doorController(string direction) //Animator function.
	{
		animator.SetTrigger(direction);
	}
		
}
