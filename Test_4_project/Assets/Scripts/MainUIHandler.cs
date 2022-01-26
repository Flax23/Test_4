using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainUIHandler : MonoBehaviour
{
    [SerializeField] private GameObject[] prefabs;
    [SerializeField] private RectTransform itemContainer;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < MainManager.Instance.itemIsSelected.Length; i++)
        {
            var item = GameObject.Instantiate(prefabs[i].gameObject) as GameObject;
            item.transform.SetParent(itemContainer, false);
            item.transform.name = prefabs[i].name;
            item.transform.localScale = new Vector3(50, 50, 0);
        } 
    }

    public void BackToMenu()
    {
        SceneManager.LoadScene(0);
    }
}
