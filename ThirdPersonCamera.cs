using UnityEngine;
using System.Collections;

public class ThirdPersonCamera : MonoBehaviour
{
	public Transform camRoot;
	public Vector2 pitchMinMax = new Vector2(-40, 85);
	public float mouseSensitivity;
	float pitch, yaw;
	void Start()
	{
		Cursor.visible = false;
	}

	void Update()
	{
		pitch -= Input.GetAxis("Mouse Y") * mouseSensitivity;
		pitch = Mathf.Clamp(pitch, pitchMinMax.x, pitchMinMax.y);

		yaw += Input.GetAxis("Mouse X") * mouseSensitivity;

		transform.eulerAngles = new Vector3(0f, yaw, 0f);
		camRoot.eulerAngles = new Vector3(pitch, camRoot.eulerAngles.y, 0f);
	}
}