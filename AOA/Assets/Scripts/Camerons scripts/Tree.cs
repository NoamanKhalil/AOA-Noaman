using UnityEngine;
using System.Collections;

public class Tree : MonoBehaviour {

	 NodeCs Root;



	// Use this for initialization
	void Start () {


		Root = new Selector (); 
		Root.ownerTree = this;
		//FindTurret x= this;
		Root.AddChild (new Sequence ());
		Root.AddChild (new Sequence ());
		Root.children [0].AddChild (new FindTurret ());
		Root.children [0].AddChild (new Attack ()); 
		Root.children [1].AddChild (new FindPlayer());
		Root.children [1].AddChild (new Attack ());
		Root.AddChild (new Flea ()); 


		Root.children [2].ownerTree = this;
		Root.children [0].children[0].ownerTree  = this;
		Root.children [1].children[1].ownerTree  = this;
		Root.children [0].children[1].ownerTree  = this;
		Root.children [1].children[0].ownerTree  = this;
	}

	// Update is called once per frame
	void Update () {

		Root.currentBehaviour ();

	}
}
