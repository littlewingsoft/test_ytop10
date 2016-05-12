using UnityEngine;
using System.Collections;

public class test_ytop : MonoBehaviour {

	// Use this for initialization
	void Start () {
		print ( "getBonus return : " + YtopApi.getBonus ("00000000") );
		//print ( "isBonusEnabled return : " + YtopApi.isBonusEnabled("00000000") );
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
