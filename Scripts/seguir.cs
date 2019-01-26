using UnityEngine;

public class seguir : MonoBehaviour
{

GameObject[] backgroundObjects;
 Vector3 lastPosition;

 void Start() {
     backgroundObjects = GameObject.FindGameObjectsWithTag("Luz");
 }

 void Update() {
     foreach(GameObject g in backgroundObjects)
         g.transform.position += (transform.position - lastPosition);
     lastPosition = transform.position;
 }
}
