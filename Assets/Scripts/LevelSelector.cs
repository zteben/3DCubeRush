using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelector : MonoBehaviour
{
    public void Select ()
    {
    switch (this.gameObject.name)
        {
            case "Button01":
                SceneManager.LoadScene("Level01");
                break;
            case "Button02":
                SceneManager.LoadScene("Level02");
                break;
            case "Button03":
                SceneManager.LoadScene("Level03");
                break;
            case "Button04":
                SceneManager.LoadScene("Level04");
                break;
            case "Button05":
                SceneManager.LoadScene("Level05");
                break;
        }
    }
}
