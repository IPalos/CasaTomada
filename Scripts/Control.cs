using UnityEngine;

public class Control : MonoBehaviour
{

	 public float velcamx = 10f;
	 public float velcamy=5f;

	 public Transform PlayerBody;

	 // void Awake(){
		//  Cursor.lockState = CursorLockMode.Locked;
	 // }

    void Update()
    {
        // var x = Input.GetAxis("Horizontal") * Time.deltaTime * 150.0f;

        RotateCamera();
    }

		void RotateCamera(){
			var camx = Input.GetAxis("Mouse X") * velcamx;
			var camy = Input.GetAxis("Mouse Y") * velcamy;

			Vector3 targetRotCam = transform.rotation.eulerAngles;
			Vector3 targetRotBody = PlayerBody.rotation.eulerAngles;

			targetRotCam.x -= camy;
			targetRotBody.y += camx;
			targetRotCam.z =0;


			transform.rotation = Quaternion.Euler(targetRotCam);
			PlayerBody.rotation = Quaternion.Euler(targetRotBody);
			{

			}
		}

}
