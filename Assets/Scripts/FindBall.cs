using UnityEngine;
using System.Collections;

public class FindBall : MonoBehaviour {

	public Ball BallScript;

	private bool noBall = true;

	public GameObject helpText;
	public GameObject clickText;

	void Start()
	{
		Renderer[] lChildRenderers= clickText.GetComponentsInChildren<Renderer>();
		foreach ( Renderer lRenderer in lChildRenderers)
		{
			lRenderer.enabled=false;
		}
	}

	void OnTriggerStay2D(Collider2D other)
	{
		if (noBall && other.tag == "FindBall") 
		{


			Renderer[] lChildRenderers1 = helpText.GetComponentsInChildren<Renderer>();
			foreach ( Renderer lRenderer in lChildRenderers1)
			{
				lRenderer.enabled=false;
			}

			Renderer[] lChildRenderers2 = clickText.GetComponentsInChildren<Renderer>();
			foreach ( Renderer lRenderer in lChildRenderers2)
			{
				lRenderer.enabled=true;
			}

			noBall = false;
			BallScript.enabled = true;

		}
	}
}
