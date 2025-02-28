using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class MenuHandler : MonoBehaviour
{
    public AudioSource source;

    public void goToMenu()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("mainMenu");
    }
    public void goToTheGame()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("gameplay");
    }

    private IEnumerator WaitForSoundAndTransition(string sceneName)
    {
        source.Play();
        yield return new WaitForSeconds(source.clip.length);
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName);
    }


    public void goToCharacter()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Character Selection");
    }


    public void goToGame()
    {
        StartCoroutine(WaitForSoundAndTransition("gameplay"));
    }

    public void restartGameScene()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void goToEndGame()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Game Over");
    }




}
