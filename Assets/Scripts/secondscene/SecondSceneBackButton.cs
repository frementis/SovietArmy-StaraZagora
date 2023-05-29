using UnityEngine;

public class SecondSceneBackButton : MonoBehaviour
{
    public g1move myScript; // здесь подставить название нужного скрипта
    public g1move myScript8;
    public g2move myScript1;
    public g2move myScript2;
    public g1rotate myScript3;
    public g1rotate myScript4;

    public h1move myScript5;
    public h1move myScript6;
    public h2move myScript7;
    public h2move myScript9;
    public h1rotate myScript10;
    public h1rotate myScript11;

    public RotateOnMoveForward myScript18;
    public RotateOnMoveForward myScript19;
    public RotateOnMoveForward myScript20;
    public RotateOnMoveForward myScript21;
    public RotateOnMoveForward myScript22;
    public RotateOnMoveForward myScript23;
    public RotateOnMoveForward myScript24;
    public RotateOnMoveForward myScript25;


    public RotateOnMoveBack myScript26;
    public RotateOnMoveBack myScript27;
    public RotateOnMoveBack myScript28;
    public RotateOnMoveBack myScript29;
    public RotateOnMoveBack myScript30;
    public RotateOnMoveBack myScript31;
    public RotateOnMoveBack myScript32;
    public RotateOnMoveBack myScript33;

    public TimeSlider myScript34;
    public TimeSliderBack myScript35;

    public void OnPauseButtonClick()
    {
        myScript.PauseScript();
        myScript1.PauseScript();
        myScript2.PauseScript();
        myScript3.PauseScript();
        myScript8.PauseScript();
        myScript4.PauseScript();

        myScript5.ResumeScript();
        myScript6.ResumeScript();
        myScript7.ResumeScript();
        myScript9.ResumeScript();
        myScript10.ResumeScript();
        myScript11.ResumeScript();



        myScript18.PauseScript();
        myScript19.PauseScript();
        myScript20.PauseScript();
        myScript21.PauseScript();
        myScript22.PauseScript();
        myScript23.PauseScript();
        myScript24.PauseScript();
        myScript25.PauseScript();

        myScript26.ResumeScript();
        myScript27.ResumeScript();
        myScript28.ResumeScript();
        myScript29.ResumeScript();
        myScript30.ResumeScript();
        myScript31.ResumeScript();
        myScript32.ResumeScript();
        myScript33.ResumeScript();

        myScript34.PauseScript();
        myScript35.ResumeScript();

    }

}
