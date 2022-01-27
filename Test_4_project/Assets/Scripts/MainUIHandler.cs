using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainUIHandler : MonoBehaviour
{
    [SerializeField] private GameObject[] prefabs;
    [SerializeField] private RectTransform itemContainer;

   
    void Start()
    {
        for (int i = 0; i < prefabs.Length; i++)
        {
            for (int j = 0; j < MainManager.Instance.itemIsSelected.Length; j++)
            {
                if (prefabs[i].name.Equals(MainManager.Instance.itemIsSelected[j]))
                {
                    var item = GameObject.Instantiate(prefabs[i].gameObject) as GameObject;
                    item.transform.SetParent(itemContainer, false);
                    item.transform.name = prefabs[i].name;
                    item.transform.localScale = new Vector3(100, 100, 1);
                    item.transform.localPosition = new Vector3(Random.Range(-200, 200), 0, 0);
                }
            }
        } 
    }

    public void BackToMenu()
    {
        SceneManager.LoadScene(0);
    }
}
