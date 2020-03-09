using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Platform2DUtils.MemorySystem;
using System.IO;
using UnityEngine.UI;

public class SearchSaves : MonoBehaviour
{
    [SerializeField]
    GameObject container;
    [SerializeField]
    GameObject srcSaveObject;

    void OnEnable()
    {
        DirectoryInfo info = new DirectoryInfo(MemorySystem.SavePath);
        FileInfo[] fileInfo = info.GetFiles();

        foreach(FileInfo f in fileInfo)
        {
            GameObject save = (GameObject) Instantiate(srcSaveObject, Vector3.zero, Quaternion.identity);
            SaveObject saveObject = save.GetComponent<SaveObject>();
            saveObject.fileName = f.Name;
            saveObject.transform.parent = container.transform;
        }
    }
}
