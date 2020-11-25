using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
	public string btype;
    public void Fast()
    {
		btype="FAST ball";
	}
	
	public void Spin()
    {
		btype="SPIN ball";
	}
	
	public void g1()
    {
		Debug.Log(btype+" 1");
	}
	public void g2()
    {
		Debug.Log(btype+" 2");
	}
	public void g3()
    {
		Debug.Log(btype+" 3");
	}
	public void g4()
    {
		Debug.Log(btype+" 4");
	}
	public void g5()
    {
		Debug.Log(btype+" 5");
	}
	public void g6()
    {
		Debug.Log(btype+" 6");
	}
	
}
