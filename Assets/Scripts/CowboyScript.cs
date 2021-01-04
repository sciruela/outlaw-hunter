using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CowboyScript : MonoBehaviour
{
 
    private float timer = 0.0f;

    void Update()
    {
     
     timer += Time.deltaTime;
     int seconds = (int) ( timer % 60 );

        if (seconds >= 4.0f)
        {
            AudioClip oAudioBang2 = Resources.Load<AudioClip>("Audio/bang2");

            AudioSource oAudioSourceBang2 = new GameObject().AddComponent<AudioSource>();
            oAudioSourceBang2.name = "Bang2";
            oAudioSourceBang2.clip = oAudioBang2;
            oAudioSourceBang2.Play();
            oAudioSourceBang2.transform.parent = null;
            Destroy(oAudioSourceBang2.gameObject, 1);


            AudioClip oAudioBang1 = Resources.Load<AudioClip>("Audio/playerhurt");

            AudioSource oAudioSource = new GameObject().AddComponent<AudioSource>();
            oAudioSource.name = "Hurt";
            oAudioSource.clip = oAudioBang1;
            oAudioSource.Play();
            oAudioSource.transform.parent = null;
            Destroy(oAudioSource.gameObject, 1);

            SceneManager.LoadScene(sceneName: "finish-screen");

        }
        
    }
}
