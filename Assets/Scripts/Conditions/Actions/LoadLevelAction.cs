using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

[AddComponentMenu("Playground/Actions/Load Level")]
public class LoadLevelAction : Action
{
	public int levelIndex = SAME_SCENE;

	public const int SAME_SCENE = -1;
	

	//Loads a new Unity scene, or reload the current one (it means all objects are reset)
	public override bool ExecuteAction(GameObject dataObject)
	{
		if(levelIndex == SAME_SCENE)
		{
			//just restart the level
			SceneManager.LoadScene(SceneManager.GetActiveScene().name, LoadSceneMode.Single);
		}
		else
		{
			//load another scene
			SceneManager.LoadScene(levelIndex, LoadSceneMode.Single);
		}

		return true;
	}
}