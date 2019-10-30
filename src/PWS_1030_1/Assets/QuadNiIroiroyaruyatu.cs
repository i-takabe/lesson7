using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuadNiIroiroyaruyatu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
		Camera cam = Camera.main;

		float distance = cam.nearClipPlane + 3.0f;

		transform.localPosition = new Vector3(0,0, distance);
		transform.localRotation = new Quaternion();

		float inv_acpect = (float)Screen.width / (float)Screen.height;
		float s = Mathf.Tan(0.5f * cam.fieldOfView * Mathf.Deg2Rad) * 2.0f * distance;
		transform.localScale = new Vector3(inv_acpect * s, s, 1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
