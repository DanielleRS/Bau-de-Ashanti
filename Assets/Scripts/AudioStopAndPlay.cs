using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class AudioStopAndPlay : MonoBehaviour
{
    private static AudioStopAndPlay _instance;

    public static AudioStopAndPlay Instance
    {
        get { return _instance; }
    }

    private void Awake()
    {
        if (_instance != null && _instance != this)
        {
            Destroy(this.gameObject);
            return;
        }

        _instance = this;
        DontDestroyOnLoad(this.gameObject);
    }


    public Image img = null;
    public Sprite nosound = null;
    public Sprite sound = null;
    // Update is called once per frame
    void Update()
    {
        if (SOM)
        {
            desligaSom();
        }
    }
    public static bool SOM = false;

    public static bool isSomAtivado = true;

    public void modificaSom()
    {
        SOM = !SOM;
    }
    public void desligaSom()
    {
        if (AudioListener.volume != 0)
        {
            AudioListener.volume = 0;
            isSomAtivado = false;
            img.sprite = nosound;
        }
        else if (AudioListener.volume == 0)
        {
            AudioListener.volume = 1;
            isSomAtivado = true;
            img.sprite = sound;

        }
        SOM = false;
    }
}