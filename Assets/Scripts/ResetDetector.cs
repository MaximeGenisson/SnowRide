using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResetDetector : MonoBehaviour
{

    [SerializeField] ParticleSystem crashEffect;
    // Start is called before the first frame update
    [SerializeField] AudioClip crashSFX;
    bool hasNotCrached = true;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

        private void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "Ground" && hasNotCrached){
            hasNotCrached = false;
            FindObjectOfType<PlayerController>().DisableControls();
            crashEffect.Play();
            Invoke("ReloadScene", 1.5f);
            GetComponent<AudioSource>().PlayOneShot(crashSFX);
        }
    }

    void ReloadScene(){
        SceneManager.LoadScene("Level 1");
    }
}
