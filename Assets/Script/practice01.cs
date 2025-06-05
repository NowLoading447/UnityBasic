using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class practice01 : MonoBehaviour
{
    public string myName = "조민식";
    public int age = 30;
    public float height = 185.0f;
    public bool student = true;
    public string mbti = "ENTP";
    public string gender = "남성";
    public string[] hobbies = { "게임", "독서", "게임 기획"};
    public string favColor = "청록색";
    public int birthday = 19960611;
    public string saysomthing = "조민식이라고 합니다. 잘 부탁드립니다.";

    void print()
    {
        Debug.Log("이름: " + myName);
        Debug.Log("나이: " + age);
        Debug.Log("키: " + height + "cm");
        Debug.Log("경일 게임 아카데미 학생인가?: " + student);
        Debug.Log("MBTI: " + mbti);
        Debug.Log("성별: " + gender);
        Debug.Log("취미: " + string.Join(", ", hobbies));
        Debug.Log("좋아하는 색: " + favColor);
        Debug.Log("생일: " + birthday);
        Debug.Log("한마디: " + saysomthing);
    }

    void Start()
    {
        print();
    }
}
