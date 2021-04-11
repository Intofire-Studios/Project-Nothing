using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MoneyIvent : MonoBehaviour {
	public int Money;
	public Text txt;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		txt.text = "" + Money;
	}
}
