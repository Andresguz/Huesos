using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class lvl2 : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag=="Player")
        {
            PlayerPrefs.DeleteKey("checkPointX");
            PlayerPrefs.DeleteKey("checkPointY");

            PlayerPrefs.SetInt("nivelX", 2);
            SceneManager.LoadScene("level2s");
        }
    }
}
