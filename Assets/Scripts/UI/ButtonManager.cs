using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    private Button button;

    // Start is called before the first frame update
    private void Start()
    {
        button = GetComponent<Button>();

        if (button != null)
        {
            button.onClick.AddListener(ChangeScene);
        }
    }


    private void ChangeScene()
    {
        SceneManager.LoadScene("MainScene");
    }

}
