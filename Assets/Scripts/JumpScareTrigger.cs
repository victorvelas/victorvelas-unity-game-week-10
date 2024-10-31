using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class JumpScareTriger : MonoBehaviour
{
    // Start is called before the first frame update
    public Image jumpscareImage; // La imagen que cubrirá la pantalla
    public AudioSource jumpscareAudio; // El audio del jumpscare
    public string currentSceneName; // Nombre de la escena para reiniciar
    private bool isCaught = false;
    void Start()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !isCaught)
        {
            isCaught = true;
            StartCoroutine(TriggerJumpscare());
        }
    }


    void pauseMusic()
    {
        foreach(AudioSource a in FindObjectsOfType<AudioSource>())
        {
            if (a.isPlaying)
            {
                a.Pause();
            }
        }
    }

    private IEnumerator TriggerJumpscare()
    {
        // Mostrar la imagen
        jumpscareImage.enabled = true;
        // Reproducir el audio
        pauseMusic();
        jumpscareAudio.Play();

        // Esperar a que termine el audio
        yield return new WaitForSeconds(jumpscareAudio.clip.length);

        // Reiniciar el nivel
        //SceneManager.LoadScene(currentSceneName);
        //Application.LoadLevel(0);
        SceneManager.LoadScene(currentSceneName);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
