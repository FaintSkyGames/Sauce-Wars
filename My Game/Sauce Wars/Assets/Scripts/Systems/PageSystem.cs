using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PageSystem : MonoBehaviour {

    private string currentPage = "Page 1";

    public GameObject backButton;
    public GameObject nextButton;

    public GameObject page1;
    public GameObject page2;
    public GameObject page3;
    public GameObject page4;
    public GameObject page5;
    public GameObject page6;

    // Use this for initialization
    void Start () {
        page2.SetActive(false);
        page3.SetActive(false);
        page4.SetActive(false);
        page5.SetActive(false);
        page6.SetActive(false);
        backButton.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
        if (true)
        {

        }
	}

    public void Next()
    {
        if (currentPage == "Page 1")
        {
            page2.SetActive(true);
            page1.SetActive(false);
            currentPage = "Page 2";
            backButton.SetActive(true);
            
        }
        else if (currentPage == "Page 2")
        {
            page3.SetActive(true);
            page2.SetActive(false);
            currentPage = "Page 3";
        }
        else if (currentPage == "Page 3")
        {
            page4.SetActive(true);
            page3.SetActive(false);
            currentPage = "Page 4";
        }
        else if (currentPage == "Page 4")
        {
            page5.SetActive(true);
            page4.SetActive(false);
            currentPage = "Page 5";
        }
        else if (currentPage == "Page 5")
        {
            page6.SetActive(true);
            page5.SetActive(false);
            currentPage = "Page 6";
            nextButton.SetActive(false);
        }
    }

    public void Back()
    {
        if (currentPage == "Page 2")
        {
            page1.SetActive(true);
            page2.SetActive(false);
            currentPage = "Page 1";
            backButton.SetActive(false);
        }
        else if (currentPage == "Page 3")
        {
            page2.SetActive(true);
            page3.SetActive(false);
            currentPage = "Page 2";
        }
        else if (currentPage == "Page 4")
        {
            page3.SetActive(true);
            page4.SetActive(false);
            currentPage = "Page 3";
        }
        else if (currentPage == "Page 5")
        {
            page4.SetActive(true);
            page5.SetActive(false);
            currentPage = "Page 4";
        }
        else if (currentPage == "Page 6")
        {
            page5.SetActive(true);
            page6.SetActive(false);
            currentPage = "Page 5";
            nextButton.SetActive(true);
        }

    }
}
