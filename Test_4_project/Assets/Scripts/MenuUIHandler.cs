using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class MenuUIHandler : MonoBehaviour
{
    [SerializeField] private string itemIsSelected;
    
    public void NextScene()
    {
        MainManager.Instance.itemIsSelected[0] = itemIsSelected;
        SceneManager.LoadScene(1);       
    }

    public void Startgame()
    {
        MainManager.Instance.itemIsSelected[1] = itemIsSelected;
        SceneManager.LoadScene(2);
    }

    public void SelectedItem()
    {
        itemIsSelected = EventSystem.current.currentSelectedGameObject.name;
        //Debug.Log(itemIsSelected);
    }
}
