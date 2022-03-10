using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DialogueManager : MonoBehaviour {

	public Text nameText;

	public Animator animator;

	private Queue<string> sentences;

	// Use this for initialization
	void Start () {
		sentences = new Queue<string>();
		animator.SetBool("IsOpen",  false);
	}

	public void StartDialogue (Dialogue dialogue)
	{
		Debug.Log(nameText);
		Debug.Log(dialogue.name);

		nameText.name = dialogue.name;
		
		animator.SetBool("IsOpen",  true);
		sentences.Clear();

		foreach (string sentence in dialogue.sentences)
		{
			sentences.Enqueue(sentence);
			nameText.text = sentence;
		}

		 DisplayNextSentence();
	}

	public void DisplayNextSentence ()
	{
		
		Debug.Log("In displayNext Sentence");
 
		if (sentences.Count == 0)
		{
			EndDialogue();
			return;
		}
		
		Debug.Log("Trying");
		while(sentences.Count > 0) {
			var sentence = sentences.Dequeue();
			StartCoroutine(TypeSentence(sentence));
		}
		StopAllCoroutines();
	}


	IEnumerator TypeSentence (string sentence)
	{
		yield return new WaitForSeconds(15f);
		Debug.Log("In type Sentence");
		Debug.Log(sentence);
		nameText.text = sentence;
	}

	public void EndDialogue()
	{
		nameText.text = "";
		sentences.Clear();
		StopAllCoroutines();
		animator.SetBool("IsOpen", false);
	}

}