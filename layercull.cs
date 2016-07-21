using UnityEngine;
using System.Collections;

public class layercull : MonoBehaviour 
{
	public Camera localCamera;
	public float crewCullDistance = 0; 
	public float cannonCullDistance = 0; 
	public float fireCullDistance = 0;
	public float projectileCullDistance = 0;
	public float debrisCullDistance = 0;
	public float smokeSmallCullDistance = 0;
	public float smokeCullDistance = 0;

	void Start()
	{
		float [] distances = new float[32];
		distances[8] = projectileCullDistance;
		distances[9] = cannonCullDistance;
		distances[11] = crewCullDistance;
		distances[12] = fireCullDistance;
		distances[18] = debrisCullDistance;
		distances[19] = smokeSmallCullDistance;
		distances[20] = smokeCullDistance;

		localCamera.layerCullDistances = distances;
	}
}
