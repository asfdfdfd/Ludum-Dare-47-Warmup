using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public float VerticalSpeed;
    public float HorizontalSpeed;
    public float AirVentSpeed;

    private bool _isFrozen = false;
    
    [SerializeField] private AudioSource soundPlayerTakesBubble;
    
    private void FixedUpdate()
    {
        if (_isFrozen)
        {
            return;
        }
        
        float horizontalMovement = Input.GetAxis("Horizontal") * HorizontalSpeed * Time.deltaTime;

        Vector3 positionOld = gameObject.transform.position;
        Vector3 positionNew = new Vector3(positionOld.x + horizontalMovement,
            positionOld.y + VerticalSpeed * Time.deltaTime, positionOld.z);

        Vector3 scaleOld = gameObject.transform.localScale;
        Vector3 scaleNew = new Vector3(scaleOld.x - AirVentSpeed * Time.deltaTime,
            scaleOld.y - AirVentSpeed * Time.deltaTime, 1);

        gameObject.transform.position = positionNew;
        gameObject.transform.localScale = scaleNew;
    }

    public void AddAir(float air)
    {
        soundPlayerTakesBubble.Play();
        
        Vector3 scaleOld = gameObject.transform.localScale;
        Vector3 scaleNew = new Vector3(scaleOld.x + air, scaleOld.y + air, 1);
        
        gameObject.transform.localScale = scaleNew;
    }

    public void Win(AudioSource audioSource)
    {
        StartCoroutine(WinCoroutine(audioSource));
    }
    
    private IEnumerator WinCoroutine(AudioSource audioSource)
    {
        _isFrozen = true;

        yield return AudioSourcePlayCoroutine(audioSource);
        
        SceneManager.LoadScene("WinScene");
    }
    
    public void Kill(AudioSource audioSource)
    {
        StartCoroutine(KillCoroutine(audioSource));
    }

    private IEnumerator KillCoroutine(AudioSource audioSource)
    {
        _isFrozen = true;

        yield return AudioSourcePlayCoroutine(audioSource);
        
        SceneManager.LoadScene("GameOverScene");
    }

    private IEnumerator AudioSourcePlayCoroutine(AudioSource audioSource)
    {
        audioSource.Play();

        while (audioSource.isPlaying)
        {
            yield return null;
        }
    }
}
