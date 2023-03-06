using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{

    [SerializeField] ParticleSystem finishEffect;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "Player"){
            finishEffect.Play();
            Invoke("ReloadScene", 1.5f);
            GetComponent<AudioSource>().Play();
        }
    }

    void ReloadScene(){
        SceneManager.LoadScene("Level 1");
    }
}
