using UnityEngine;
using UnityEngine.SceneManagement;

public class changeScene : MonoBehaviour
{

public string nextLevel;

	void OnTriggerEnter2D(Collider2D coll){

		if(coll.CompareTag("Player")){
			SceneManager.LoadScene(nextLevel);
		}

	}

}
