using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CodeTimeDelayTest : MonoBehaviour
{
    public UnityEngine.UI.Text testText;

    int testInt;
    string testString;

    // Start is called before the first frame update
    void Start()
    {
        testText = GetComponent<UnityEngine.UI.Text>();
        testInt = 123;
        testString = "I'm on a boat";


        TestCode();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void TestCode()
    {
        System.Diagnostics.Stopwatch watch = new System.Diagnostics.Stopwatch();
        watch.Start();

        for (int i = 0; i < 1000000; i++)
        {
            testText.text = testInt.ToString() + " " + testString.ToString();
            //testText.text = $"{testInt} {testString}";
        }


        watch.Stop();
        Debug.Log(watch.ElapsedMilliseconds + "ms");

        watch.Start();

        for (int i = 0; i < 1000000; i++)
        {
            ////testText.text = testInt.ToString() + " " + testString.ToString();
            testText.text = $"{testInt.ToString()} {testString.ToString()}";
        }


        watch.Stop();
        Debug.Log(watch.ElapsedMilliseconds + "ms");
    }


}
