using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class practice04 : MonoBehaviour
{
    string star;

    void Start()
    {
        Phase1();
        Phase2();
        Phase3();
        Phase4();
        Phase5();
    }

    public void Phase1()
    {
        star = string.Empty;
        int height = 5;

        for (int i = 1; i <= height; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                star += "*";
            }
            star += "\n";
        }

        Debug.Log("Phase1\n" + star);
    }

    public void Phase2()
    {
        star = string.Empty;
        int height = 5;

        for (int i = height; i >= 1; i--)
        {
            for (int j = 1; j <= height - i; j++)
            {
                star += " ";
            }
            for (int k = 1; k <= i; k++)
            {
                star += "*";
            }
            star += "\n";
        }

        Debug.Log("Phase2\n" + star);
    }

    public void Phase3()
    {
        star = string.Empty;
        int height = 9;

        for (int i = 1; i <= height; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                star += "*";
            }
            star += "\n";
        }

        for (int i = height - 1; i >= 1; i--)
        {
            for (int j = 1; j <= i; j++)
            {
                star += "*";
            }
            star += "\n";
        }

        Debug.Log("Phase3\n" + star);
    }

    public void Phase4()
    {
        star = string.Empty;
        int height = 9;

        for (int i = 1; i <= height; i++)
        {
            for (int s = 1; s <= height - i; s++)
            {
                star += " ";
            }
            for (int j = 1; j <= i; j++)
            {
                star += "*";
            }
            star += "\n";
        }

        for (int i = height - 1; i >= 1; i--)
        {
            for (int s = 1; s <= height - i; s++)
            {
                star += " ";
            }
            for (int j = 1; j <= i; j++)
            {
                star += "*";
            }
            star += "\n";
        }

        Debug.Log("Phase4\n" + star);
    }

    public void Phase5()
    {
        star = string.Empty;
        int height = 9;

        for (int i = 1; i <= height; i++)
        {
            for (int j = 1; j <= height - i; j++)
            {
                star += " ";
            }
            for (int k = 1; k <= (i * 2) - 1; k++)
            {
                star += "*";
            }
            star += "\n";
        }

        for (int i = height - 1; i >= 1; i--)
        {
            for (int j = 1; j <= height - i; j++)
            {
                star += " ";
            }
            for (int k = 1; k <= (i * 2) - 1; k++)
            {
                star += "*";
            }
            star += "\n";
        }

        Debug.Log("Phase5\n" + star);
    }
}
