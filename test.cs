using UnityEngine;
using System.Collections;

public class test : MonoBehaviour
{
	public Rigidbody localRigidbody;
	public float time = 20.0f;

	private Quaternion rotationStart;
	private Quaternion rotationEnd;
	private float elapsedTime = 0.0f;

	void Start()
	{
		rotationStart = localRigidbody.rotation;
		float tempY = localRigidbody.rotation.eulerAngles.y;
		rotationEnd = Quaternion.AngleAxis(tempY + 90.0f, Vector3.up);
		StartCoroutine(Rotate());
	}

	IEnumerator Rotate()
	{
		while(elapsedTime < time)
		{
			elapsedTime += Time.deltaTime;
			localRigidbody.rotation = Quaternion.Slerp(rotationStart, rotationEnd, (elapsedTime / time));
			yield return null;
		}
	}
}
