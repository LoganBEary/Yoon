using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneLoader : MonoBehaviour
{
    public List<GameObject> SpawnPoints;

    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        if (GameManager.gameManager != null)
        {
            loadCurrentScene(GameManager.gameManager.currentScene, GameManager.gameManager.previousScene);
        }
    }

    public void loadCurrentScene(string curScene, string prevScene)
    {
        CharacterController cc = player.GetComponent<CharacterController>();
        cc.enabled = false;
        if (curScene == "Town")
        {
            if (prevScene != null)
            {
                Vector3 pos = SpawnPoints[0].transform.position;
                player.transform.SetPositionAndRotation(SpawnPoints[0].transform.position, SpawnPoints[0].transform.rotation);
            }
        }
        else if (curScene == "FirstLevel")
        {
            if (prevScene == "Town")
            {
                player.transform.SetPositionAndRotation(SpawnPoints[0].transform.position, SpawnPoints[0].transform.rotation);
            }
            else if (prevScene == "SecondLevel")
            {
                player.transform.SetPositionAndRotation(SpawnPoints[1].transform.position, SpawnPoints[1].transform.rotation);
            }
        }
        else if (curScene == "SecondLevel")
        {
            player.transform.SetPositionAndRotation(SpawnPoints[0].transform.position, SpawnPoints[0].transform.rotation);
        }
        cc.enabled = true;
    }
}
