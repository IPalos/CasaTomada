using UnityEngine;

// C# example.

public class SunRays : MonoBehaviour
{

    // public GameObject shine;
    GameObject shine;

    private CheckRay checkray;

    void Awake(){


    }

    void Update()
    {
        // Bit shift the index of the layer (8) to get a bit mask
				GenerateRays();



    }

		void GenerateRays(){

			int layerMask = 1 << 8;

			// This would cast rays only against colliders in layer 8.
			// But instead we want to collide against everything except layer 8. The ~ operator does this, it inverts a bitmask.
			//layerMask = ~layerMask;

			for (int i=0; i<81; i++) {
					RaycastHit hit;
					Vector3 pos = transform.position;
					pos.x=transform.position.x - 4 + (i % 9);
					pos.z=transform.position.z -4 + (i / 9);

					// Does the ray intersect any objects excluding the player layer
					if (Physics.Raycast(pos, transform.TransformDirection(Vector3.forward), out hit, Mathf.Infinity, layerMask))
					{

              shine=hit.collider.gameObject;

              checkray = shine.GetComponent<CheckRay>();
              checkray.brillo+=1;

							Debug.DrawRay(pos, transform.TransformDirection(Vector3.forward) * hit.distance, Color.yellow);
							Debug.Log("Did Hit");
					}
					else
					{
							Debug.DrawRay(pos, transform.TransformDirection(Vector3.forward) * 1000, Color.white);
							Debug.Log("Did not Hit");
					}


			}

		}




}
